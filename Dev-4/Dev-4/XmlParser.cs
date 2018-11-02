using System;
using System.Collections.Generic;

namespace Dev_4
{
    /// <summary>
    /// This class contain methods for parsing xml file
    /// gets string text as arguments
    /// returns object of Node type as a result
    /// or exception ("error during parsing text")
    /// </summary>
    class XmlParser
    {
        private Node rootNode;
        private Dictionary<int,Node> rootList;
        private List<string> tagNames;
        /// <summary>
        /// class constructor
        /// </summary>
        public XmlParser ()
        {
            rootNode = new Node();
            rootList = new Dictionary<int, Node>();
            tagNames = new List<string>();
        }
        /// <summary>
        /// Parse the xml file
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// return Node that contain all information from xml file
        /// </returns>
        public Node ParseXml(string text)
        {
            try
            {
                string newText;
                newText = text.Replace("  ", " ");
                newText = newText.Replace("<", "@<");
                newText = newText.Replace(">", ">@");
                string[] splitedText;
                splitedText = newText.Split('@');
                for (int i = 0; i < splitedText.Length; i++)
                {
                    if (ReadAttribute(splitedText[i]))
                    {
                        tagNames.Add(splitedText[i]);
                    }
                }

                int counter = 0;
                foreach (string i in tagNames)
                {
                    string complexName = string.Empty;
                    Node temporaryNode = new Node();
                    complexName = i.Replace("<", "");
                    complexName = complexName.Replace(">", "");
                    string[] splitedAttribute = complexName.Split(' ');
                    temporaryNode.Name = splitedAttribute[0];
                    if (splitedAttribute.Length > 1)
                    {
                        for (int j = 1; j < splitedAttribute.Length; j++)
                        {
                            string [] splitedProperty = splitedAttribute[j].Split('=');
                            temporaryNode.AddProperties(splitedProperty[0], splitedProperty[1]);
                        }
                    }
                    if (EndFlag(i))
                    {
                        temporaryNode.Flag = true;
                    }
                    rootList.Add(counter,temporaryNode);
                    counter++;
                }
                AddInfoFromText(ref splitedText);
                int maxDepth = FindMaxDepth();
                int executedElementPosition = new int();
                for (int j = maxDepth; j > 0; j--)
                {
                    executedElementPosition = 0;
                    for (int i = 0; i < rootList.Count;i++)
                    {
                        if (rootList[i].Flag == true)
                        {
                            continue;
                        }
                        if (rootList[i].Depth + 1 == maxDepth && 
                            rootList[i+1].Depth == maxDepth )
                        {
                            executedElementPosition = i;
                            continue;
                        }
                        if (rootList[i].Depth == maxDepth)
                        {
                            rootList[executedElementPosition].AddNewIncludedList(rootList[i]);
                        }
                    }
                    maxDepth--;
                }
                rootNode = rootList[0];
                return rootNode;
            }catch
            {
                throw new Exception("Error during parsing text");
            }
        }
        /// <summary>
        /// check string if it is a tag 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// returns true if string is a tag
        /// returns false if not
        /// </returns>
        public bool ReadAttribute(string text)
        {
            if (text.IndexOf("<") > -1 || text.IndexOf(">") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// check if the string is end tag
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// return true if string is a end tag
        /// false if not
        /// </returns>
        public bool EndFlag(string text)
        {
            if (text.IndexOf("</") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// maches each tag its info
        /// if tag doesn't contain information - field info is null
        /// </summary>
        /// <param name="splitedText"></param>
        public void AddInfoFromText (ref string[] splitedText)
        {
            for (int i = 0; i < splitedText.Length; i++)
            {
                if (splitedText[i].Length > 2 &&
                    tagNames.IndexOf(splitedText[i]) == -1)
                {
                    int indexInRootList;
                    indexInRootList = tagNames.IndexOf(splitedText[i - 1]);
                    tagNames[indexInRootList] = string.Empty;
                    Node temporaryNode = rootList[indexInRootList];
                    temporaryNode.information = splitedText[i];
                    rootList.Remove(indexInRootList);
                    rootList.Add(indexInRootList, temporaryNode);
                }
            }
        }
        /// <summary>
        /// matches each node its nesting depth
        /// </summary>
        /// <returns>returns the max depth of whole xml file</returns>
        public int FindMaxDepth ()
        {
            int depthCounter = new int();
            int maxDepth = new int();
            for (int i = 0; i < rootList.Count; i++)
            {
                if (depthCounter > maxDepth)
                {
                    maxDepth = depthCounter;
                }
                rootList[i].Depth = depthCounter;
                if (rootList[i].information == null)
                {
                    if (rootList[i].Flag == false)
                    {
                        depthCounter++;
                    }
                    else
                    {
                        depthCounter--;
                    }
                }
                if (rootList[i].information != null)
                {
                    i++;
                }
            }
            return maxDepth;
        }
    }
}

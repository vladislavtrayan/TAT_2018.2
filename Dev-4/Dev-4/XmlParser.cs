using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class XmlParser
    {
        Node rootNode = new Node();
        Dictionary<int,Node> rootList = new Dictionary<int, Node>();
        List<string> tagNames = new List<string>();

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
                    if (ReadAttribute(splitedText[i]) && !EndFlag(splitedText[i]))
                    {
                        tagNames.Add(splitedText[i]);
                    }
                }
                int counter = 0;

                foreach (string i in tagNames)
                {
                    Node temporaryNode = new Node();
                    i.Replace("<", "");
                    i.Replace(">", "");
                    string[] splitedAttribute = i.Split(' ');
                    temporaryNode.Name = splitedAttribute[0];
                    if (splitedAttribute.Length > 1)
                    {
                        for (int j = 1; j < splitedAttribute.Length; j++)
                        {
                            temporaryNode.AddProperties(splitedAttribute[j]);
                        }
                    }
                    rootList.Add(counter,temporaryNode);
                }
                for (int i = 0; i < splitedText.Length; i++)
                {
                    if (splitedText[i].Length > 2 &&
                        tagNames.IndexOf(splitedText[i]) == -1 &&
                        !EndFlag(splitedText[i]))
                    {
                        int indexInRootList;
                        indexInRootList = tagNames.IndexOf(splitedText[i - 1]);
                        Node temporaryNode = rootList[indexInRootList];
                        temporaryNode.information = splitedText[i];
                        rootList.Remove(indexInRootList);
                        rootList.Add(indexInRootList,temporaryNode);
                    }
                }
                for (int i = rootList.Count; i >  0; i--)
                {
                    if (rootList[i].information != null)
                    {
                        rootList[i - 1].AddNewIncludedList(rootList[i]);
                    }
                }
                for (int i = 1; i < rootList.Count;i++)
                {
                    if (rootList[i].information == null)
                    {
                        rootList[i - 1].AddNewIncludedList(rootList[i]);
                    }
                }
                rootNode = rootList[0];
                return rootNode;
            }catch
            {
                throw new Exception("((");
            }
        }
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
    }
}

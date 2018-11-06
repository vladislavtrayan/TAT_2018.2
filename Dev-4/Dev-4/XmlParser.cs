using System.Text;
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
        List<string> tagLines;
        List<string[]> result;
        /// <summary>
        /// class constructor
        /// </summary>
        public XmlParser ()
        {
            result = new List<string[]>();
            tagLines = new List<string>();
        }
        /// <summary>
        /// Parse the xml file
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// return Node that contain all information from xml file
        /// </returns>
        public void ParseXml(string text)
        {
            string newText;
            newText = text.Replace("  ", " ");
            newText = newText.Replace("<", "@<");
            newText = newText.Replace(">", ">@");
            string[] splitedText;
            splitedText = newText.Split('@');

            ReConstructTagAttribute(ref splitedText);
            StringBuilder temporaryStringBuilder = new StringBuilder();
            int i = 0;
            while (i != splitedText.Length)
            {
                i = 0;
                for (; i < splitedText.Length; i++)
                {
                    if (IsTrash(splitedText[i]))
                    {
                        continue;
                    }
                    if (EndFlag(splitedText[i]))
                    {
                        splitedText[i] = string.Empty;
                        for (int j = i;j > 0;j--)
                        {
                            if (IsTag(splitedText[j]) &&
                                !EndFlag (splitedText[j]))
                            {
                                splitedText[j] = string.Empty;
                                break;
                            }
                        }
                    }
                    if (!IsTag(splitedText[i + 1]) &&
                        !EndFlag(splitedText[i + 1]) &&
                        splitedText[i + 1] != string.Empty &&
                        !IsTrash(splitedText[i + 1]))
                    {
                        temporaryStringBuilder.Append(splitedText[i]);
                        temporaryStringBuilder.Append("/");
                        temporaryStringBuilder.Append(splitedText[i + 1]);
                        splitedText[i] = string.Empty;
                        splitedText[i + 1] = string.Empty;
                        splitedText[i + 2] = string.Empty;
                        tagLines.Add(temporaryStringBuilder.ToString());
                        temporaryStringBuilder.Clear();
                        break;
                    }
                    temporaryStringBuilder.Append(splitedText[i]);
                    temporaryStringBuilder.Append("/");
                }
            }
            for (int j = 0; j < tagLines.Count;j++)
            {
                result.Add(tagLines[j].Split('/'));
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
        public bool IsTag(string text)
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
        public bool IsTrash (string text)
        {
            for (int i = 0; i < text.Length;i++)
            {
                if (text[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        public void ReConstructTagAttribute (ref string[] splitedText)
        {
            string[] splitedAttribute;
            StringBuilder convertedTag = new StringBuilder();
            for (int i = 0; i < splitedText.Length;i++)
            {
                convertedTag.Clear();
                if (IsTag(splitedText[i]) &&
                    !EndFlag(splitedText[i]))
                {
                    splitedText[i] = splitedText[i].Replace("<","");
                    splitedText[i] = splitedText[i].Replace(">","");
                    splitedAttribute = splitedText[i].Split(' ');
                    convertedTag.Append("< ");
                    convertedTag.Append(splitedAttribute[0]);
                    convertedTag.Append("[ ");
                    for (int j = 1; j < splitedAttribute.Length;j++)
                    {
                        convertedTag.Append(splitedAttribute[j]);
                    }
                    convertedTag.Append(" ] >");
                    splitedText[i] = convertedTag.ToString();
                }
            }
        }
    }
}

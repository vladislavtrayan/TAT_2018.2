using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_6
{
    class JsonParser
    {
        List<string> tagLines;
        List<string[]> result;
        public JsonParser ()
        {
            tagLines = new List<string>();
            result = new List<string[]>();
        }
        public List<string[]> ParseJson(string text)
        {
            string[] splitedText;
            SliceText(text, out splitedText);
            ReConstructTagAttribute(ref splitedText);
            StringBuilder temporaryStringBuilder = new StringBuilder();
            temporaryStringBuilder.Append("<: \"root\" :>/");
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
                    if (CheckFlagForBranches(splitedText[i]))
                    {
                        continue;
                    }
                    if (CheckFlagForEndBranch(splitedText[i]))
                    {
                        splitedText[i] = string.Empty;
                        for (int j = i; j > 0; j--)
                        {
                            if (CheckFlagForBranches(splitedText[j]))
                            {
                                splitedText[j] = string.Empty;
                                break;
                            }
                            splitedText[j] = string.Empty;
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (ContainsInformation(splitedText[j]) ||
                                j == 0 ||
                                CheckFlagForBranches(splitedText[j]))
                            {
                                tagLines.Add(temporaryStringBuilder.ToString());
                                temporaryStringBuilder.Clear();
                                temporaryStringBuilder.Append("<: \"root\" :>");
                                i = 0;
                                break;
                            }
                            splitedText[j] = string.Empty;
                        }
                    }
                    if (EndFlag(splitedText[i]))
                    {
                        splitedText[i] = string.Empty;
                        for (int j = i; j > 0; j--)
                        {
                            if (CheckFlagForBranches(splitedText[j]) &&
                                !EndFlag(splitedText[j]))
                            {
                                if (temporaryStringBuilder.Capacity != 0)
                                {
                                    tagLines.Add(temporaryStringBuilder.ToString());
                                }
                                temporaryStringBuilder.Clear();
                                temporaryStringBuilder.Append("<: \"root\" :>");
                                i = 0;
                                break;
                            }
                            splitedText[j] = string.Empty;
                        }
                    }
                    temporaryStringBuilder.Append(splitedText[i]);
                    temporaryStringBuilder.Append("/");
                }
            }
            for (int j = 0; j < tagLines.Count; j++)
            {
                result.Add(tagLines[j].Split('/'));
            }
            return result;
        }
        private bool EndFlag (string text)
        {
            if (text == ",")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ContainsInformation(string text)
        {
            if (text.IndexOf("$$$") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void SliceText (string text , out string[] splitedText)
        {
            string newText = string.Empty;
            newText = text.Replace("#", "$$$");
            newText = newText.Replace(":", "#:#");
            newText = newText.Replace("{", "#{#");
            newText = newText.Replace("}", "#}#");
            newText = newText.Replace("[", "[#");
            newText = newText.Replace("]", "#]#");
            newText = newText.Replace(",", "#,#");
            splitedText = newText.Split('#');
            for (int i = 0; i < splitedText.Length;i++)
            {
                splitedText[i] = splitedText[i].Replace("$$$", "#");
            }
        }
        private bool IsTag(string text)
        {
            if (text.IndexOf(":") > -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckFlagForBranches(string text)
        {
            if (text.IndexOf("{") > -1 || text.IndexOf("[") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsMassive (string text)
        {
            if (text.IndexOf("[") > -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckFlagForEndBranch(string text)
        {
            if (text.IndexOf("}") > -1 || text.IndexOf("]") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsTrash(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private void ReConstructTagAttribute(ref string[] splitedText)
        {
            StringBuilder convertedTag = new StringBuilder();
            StringBuilder temporaryNameForMassive = new StringBuilder();
            for (int i = 1; i < splitedText.Length - 1; i++)
            {
                convertedTag.Clear();
                if (IsTag(splitedText[i]) &&
                    !CheckFlagForBranches(splitedText[i + 1]) &&
                    !IsTrash(splitedText[i + 1]))
                {
                    convertedTag.Append("<: ");
                    convertedTag.Append(splitedText[i - 1]);
                    convertedTag.Append(" :> ");
                    convertedTag.Append("/");
                    convertedTag.Append(splitedText[i + 1]);
                    splitedText[i - 1] = convertedTag.ToString();
                    splitedText[i] = string.Empty;
                    splitedText[i + 1] = string.Empty;
                    continue;
                }
                if (IsTag(splitedText[i]))
                {
                    //temporaryNameForMassive.Clear();
                    //temporaryNameForMassive.Append("<: "); 
                    //temporaryNameForMassive.Append(splitedText[i - 1].Substring(0, splitedText[i - 1].Length - 2));
                    //temporaryNameForMassive.Append('"');
                    //temporaryNameForMassive.Append(" :> ");
                    convertedTag.Append("<: ");
                    convertedTag.Append(splitedText[i - 1]);
                    convertedTag.Append(" :> ");
                    splitedText[i - 1] = convertedTag.ToString();
                   // splitedText[i - 1] = string.Empty;
                    splitedText[i] = string.Empty;
                    continue;
                }
                //if (IsMassive(splitedText[i]))
                //{
                //    splitedText[i] = temporaryNameForMassive.ToString(); 
                //}
            }
        }
    }
}

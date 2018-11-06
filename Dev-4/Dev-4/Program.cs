using System;

namespace Dev_4
{
    /// <summary>
    /// Entry point of program
    /// get path to xml file as an argument
    /// and parse the document to new structure
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new Exception("No arguments");
                }
                if (args.Length > 1)
                {
                    throw new Exception("too many arguments");
                }
                string text = string.Empty;
                XmlToStringConvertor xmlToStringConvertor = new XmlToStringConvertor();
                text = xmlToStringConvertor.ReadXmlFile(args[0]);
                XmlParser xmlParser = new XmlParser();
                xmlParser.ParseXml(text);
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
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

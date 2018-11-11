using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_6
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatChecker formatChecker = new FormatChecker();
            FileToStringConvertor fileToStringConvertor = new FileToStringConvertor();
            JsonParser jsonParser = new JsonParser();
            XmlParser xmlParser = new XmlParser();
            List<string[]> jsonConverted;
            List<string[]> xmlConverted;
            string text = string.Empty;
            string text1 = string.Empty;
            text = fileToStringConvertor.ReadTextFromFile(args[0]);
            text1 = fileToStringConvertor.ReadTextFromFile(args[1]);
            jsonConverted = jsonParser.ParseJson(text);
            xmlConverted = xmlParser.ParseXml(text1);
            int result = 0;
            result =  formatChecker.CheckFormat(text);
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class XmlToStringConvertor
    {
        public string ReadXmlFile (string fileName)
        {
            StringBuilder temporaryText = new StringBuilder();
            using (StreamReader InputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = InputFile.ReadLine()) != null)
                {
                    temporaryText.Append(line);
                }
            }
        return temporaryText.ToString();
        }
    }
}

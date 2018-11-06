using System.IO;
using System.Text;

namespace Dev_4
{
    /// <summary>
    /// convert text from xml file 
    /// to string 
    /// </summary>
    class XmlToStringConvertor
    {
        /// <summary>
        /// convert text from xml file 
        /// returns string type value
        /// </summary>
        /// <param name="fileName">file name of xml file</param>
        /// <returns>string text read from file</returns>
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

using System.IO;
using System.Text;

namespace Dev_6
{
    class FileToStringConvertor
    {
        public string ReadTextFromFile (string fileName)
        {
            StringBuilder text = new StringBuilder();
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    text.Append(line);
                }
            }
            return text.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_6
{
    class FormatChecker
    {
        /// <summary>
        /// Checking the text if it is Json , Xml or not
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// returns 1 ,if text is in Xml
        /// returns -1 ,if text is in Json
        /// returns 0 ,if text isn't Json or Xml
        /// </returns>
        public int CheckFormat (string text)
        {
            foreach (char i in text)
            {
                if (i == '{')
                {
                    return -1;
                }
                if (i == '<')
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}

using System;
using System.Text;

namespace Dev_2
{
    class ArrayToString
    {
        /// <summary>
        /// convert array to string
        /// </summary>
        /// <param name="initialArguments"></param>
        /// <returns>return string </returns>
        public String ConvertArrayToString (String[] initialArguments)
        {
            try
            {
                StringBuilder str = new StringBuilder();
                foreach (String i in initialArguments)
                {
                    str.Append(i);
                    str.Append(" ");
                }
                return str.ToString();
            }catch
            {
                throw new Exception("Can't convert Array<String> to String");
            }
        }
    }
}

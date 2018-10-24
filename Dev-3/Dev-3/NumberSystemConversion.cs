using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_3
{
    /// <summary>
    /// Converts decimal number into other number system 
    /// </summary>
    class NumberSystemConversion
    {
        /// <summary>
        /// property for NewSystemBase 
        /// </summary>
        public int NewSystemBase{get; set;}
        /// <summary>
        /// class constructor
        /// </summary>
        /// <param name="newBase">the base of new number system</param>
        public NumberSystemConversion (int newBase)
        {
            NewSystemBase = newBase;
        }
        /// <summary>
        /// convert param to new number system according to base of class object
        /// </summary>
        /// <param name="number"></param>
        /// <returns>converted number into new number system in a string</returns>
        public string ConvertIntToNewSystem (int number)
        {
            try
            {
                int temporaryNumber = new int();
                temporaryNumber = Math.Abs(number);

                StringBuilder convertedNumber = new StringBuilder();
                int currentElement = new int();

                do
                {
                    currentElement = temporaryNumber % NewSystemBase;
                    temporaryNumber = temporaryNumber / NewSystemBase;
                    convertedNumber.Insert(0, IntToString(currentElement));
                }  while (temporaryNumber != 0) ;

                if (Math.Sign(number) == -1)
                {
                    convertedNumber.Insert(0, '-');
                }

                return convertedNumber.ToString();

            }catch
            {
                throw new Exception("There are some problems in conversion");
            }
        }
        /// <summary>
        /// convert int number to corresponding string 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>return the string value of number</returns>
        public string IntToString (int number)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                [0] = "0",
                [1] = "1",
                [2] = "2",
                [3] = "3",
                [4] = "4",
                [5] = "5",
                [6] = "6",
                [7] = "7",
                [8] = "8",
                [9] = "9",
                [10] = "A",
                [11] = "B",
                [12] = "C",
                [13] = "D",
                [14] = "E",
                [15] = "F",
                [16] = "G",
                [17] = "H",
                [18] = "I",
                [19] = "J"
            };
            return dictionary[number];
        }
    }
}

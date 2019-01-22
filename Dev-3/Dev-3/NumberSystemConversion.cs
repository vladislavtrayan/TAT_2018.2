using System;
using System.Collections.Generic;
using System.Text;

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

                    if (currentElement < 10)
                    {
                        char charNumber = (char)('0' + currentElement);
                        convertedNumber.Insert(0, charNumber.ToString());
                    }else
                    {
                        char charNumber = (char)('A' + currentElement - 10);
                        convertedNumber.Insert(0, charNumber.ToString());
                    }
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
    }
}

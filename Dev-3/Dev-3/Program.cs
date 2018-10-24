using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_3
{
    /// <summary>
    /// The start point of program 
    /// Accept two arguments from comand line 
    /// Convert first argument from decimal system 
    /// to new number system with second arrgument as a base
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int initialNumber = Convert.ToInt32(args[0]);
                int baseOfNewNumberSystem = Convert.ToInt32(args[1]);

                if (baseOfNewNumberSystem < 2 || baseOfNewNumberSystem > 20)
                {
                    throw new Exception("Base of new number is out of range (input : 2 <= new base <= 20 )");
                }

                NumberSystemConversion classObject = new NumberSystemConversion(baseOfNewNumberSystem);
                String convertedNumber = String.Empty;
                convertedNumber = classObject.ConvertIntToNewSystem(initialNumber);

                Console.WriteLine("Initial number : " + initialNumber + " was converted into new number system with base : " 
                    + baseOfNewNumberSystem + " , converted number is : " + convertedNumber);

            }catch(Exception e)
            {
                Console.WriteLine("Exception message : " + e.Message);
            }
        }
    }
}

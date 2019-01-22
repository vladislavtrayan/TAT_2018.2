using System;

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
        const int minBase = 2;
        const int MaxBase = 20;
    
        static void Main(string[] args)
        {
            try
            {
                int initialNumber = Convert.ToInt32(args[0]);
                int baseOfNewNumberSystem = Convert.ToInt32(args[1]);

                if (baseOfNewNumberSystem < minBase || baseOfNewNumberSystem > MaxBase)
                {
                    throw new Exception("Base of new number is out of range (input : 2 <= new base <= 20 )");
                }

                NumberSystemConversion numberSystemConversion = new NumberSystemConversion(baseOfNewNumberSystem);
                String convertedNumber = String.Empty;
                convertedNumber = numberSystemConversion.ConvertIntToNewSystem(initialNumber);

                Console.WriteLine("Initial number : " + initialNumber + " was converted into new number system with base : " 
                    + baseOfNewNumberSystem + " , converted number is : " + convertedNumber);

            }catch(Exception e)
            {
                Console.WriteLine("Exception message : " + e.Message);
            }
        }
    }
}

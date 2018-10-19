using System;
using System.Text;

namespace Dev_1
{
    class FinderOfMaximumSubsequenceOfUniqueElements
    {
        /// <summary>
        /// Entry point of the program
        /// </summary>
        /// <param name="args"></param>
        
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments"); // checking if there is no arguments 
                return 0;
            }

            StringBuilder initialLineOfElements = new StringBuilder(); 
            for (int  i = 0; i < args.Length; i++)
            {
                initialLineOfElements.Append(args[i]).Append(" ");   // if there more then one argument - sum all the arguments into one string
            }

            LenghtOfMaxSubsequence classObject = new LenghtOfMaxSubsequence(initialLineOfElements);
            Console.WriteLine(classObject.GetMaximumLenghtOfUniqueSequence());
            return 0;
        }
    }
}

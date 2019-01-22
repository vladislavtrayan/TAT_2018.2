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
        
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    throw new Exception("No arguments");
                }

                StringBuilder initialLineOfElements = new StringBuilder();
                LenghtOfMaxSubsequence classObject = new LenghtOfMaxSubsequence(initialLineOfElements);
                Console.WriteLine(classObject.GetMaximumLenghtOfUniqueSequence());

            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;

namespace Dev_1
{
    class MainApplication
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments"); // checking if there is no arguments 
                return 0;
            }

            string initialLineOfElements = String.Empty; 
            for (int  i = 0; i < args.Length; ++i)
            {
                initialLineOfElements += args[i]; // if there more then one argument - sum all the arguments into one string
                if (!(i == args.Length - 1))
                {
                    initialLineOfElements += " ";
                }
            }

            int lenghtOfSubSequence = initialLineOfElements.SearchMaximumLenghtOfUniqueSequence();
            if (!(lenghtOfSubSequence == 0))
            {
                Console.WriteLine(lenghtOfSubSequence);
            }

            return 0;
        }
    }
}

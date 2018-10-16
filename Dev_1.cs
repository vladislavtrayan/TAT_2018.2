using System;
using System.Linq;

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
            }
            string maximumSequenceOfElements = String.Empty;
            string currentSequenceOfElements = String.Empty;

            try
            {
                for (int i = 0; i < initialLineOfElements.Length; ++i)
                {
                    for (int j = i; j < initialLineOfElements.Length; ++j)
                    {
                        if (!currentSequenceOfElements.Contains(initialLineOfElements[j])) 
                        {
                            currentSequenceOfElements += initialLineOfElements[j]; 
                        }
                        else
                        {
                            if (maximumSequenceOfElements.Length < currentSequenceOfElements.Length)
                            {
                                maximumSequenceOfElements = currentSequenceOfElements;
                            }
                            currentSequenceOfElements = String.Empty;
                            break;

                        }
                    }
                }
            } catch (Exception e )
            {
                Console.WriteLine(e.Message); // if there is a exception  - just break the program
                return 0;
            }
            Console.WriteLine("Maximum sequence of not unique elements : " + maximumSequenceOfElements.Length);
            return 0;
        }
    }
}

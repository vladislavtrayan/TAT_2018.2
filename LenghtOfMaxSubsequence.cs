using System;
using System.Linq;

namespace Dev_1
{
    static class LenghtOfMaxSubsequence
    {
        public static int SearchMaximumLenghtOfUniqueSequence(this string initialLineOfElements)
        {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // if there is a exception  - just break the program
                return 0;
            }

            return maximumSequenceOfElements.Length;
        }
    }
}

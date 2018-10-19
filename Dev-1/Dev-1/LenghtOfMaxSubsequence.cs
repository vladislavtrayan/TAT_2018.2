using System;
using System.Linq;
using System.Text;

namespace Dev_1
{
    class LenghtOfMaxSubsequence
    {
        /// <summary>
        /// Count the maximum number of unique elements in the sequence
        /// </summary>
        
        private StringBuilder initialLineOfElements = new StringBuilder();
        public LenghtOfMaxSubsequence() {}
        public LenghtOfMaxSubsequence(StringBuilder initial) { initialLineOfElements = initial; }
        public  int GetMaximumLenghtOfUniqueSequence()
        {
            /// <summary>
            /// Method counts the maximum number of unique elements 
            /// <param name="initialLineOfElements">Privite field of LenghtOfMaxSubsequence object</param>
            /// <returns>
            /// Return <int> maximum number of unique elements in sequence
            /// </returns>
            /// </summary>
            StringBuilder maximumSequenceOfElements = new StringBuilder();
            StringBuilder currentSequenceOfElements = new StringBuilder();

            try
            {
                for (int i = 0; i < initialLineOfElements.Length; i++)
                {
                    for (int j = i; j < initialLineOfElements.Length; j++)
                    {
                        if (!(currentSequenceOfElements.ToString()).Contains(initialLineOfElements[j]))
                        {
                            currentSequenceOfElements.Append(initialLineOfElements[j]);
                        }
                        else
                        {
                            if (maximumSequenceOfElements.Length < currentSequenceOfElements.Length)
                            {
                                maximumSequenceOfElements.Clear();
                                maximumSequenceOfElements.Append(currentSequenceOfElements.ToString());
                            }
                            currentSequenceOfElements.Clear();
                            break;

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            return maximumSequenceOfElements.Length;
        }
    }
}

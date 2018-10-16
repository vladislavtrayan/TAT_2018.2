using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_1
{
    class MainApplication
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
                return 0;
            }

            string maximumSequenceOfelements = String.Empty;
            string currentSequenceOfelements = String.Empty;

            try
            {
                for (int i = 0; i < args[0].Length; ++i)
                {
                    for (int j = i; j < args[0].Length; ++j)
                    {
                        if (!currentSequenceOfelements.Contains(args[0][j]))
                        {
                            currentSequenceOfelements += args[0][j];
                        }
                        else
                        {
                            if (maximumSequenceOfelements.Length < currentSequenceOfelements.Length)
                            {
                                maximumSequenceOfelements = currentSequenceOfelements;
                            }
                            currentSequenceOfelements = String.Empty;
                            break;

                        }
                    }
                }
            } catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(maximumSequenceOfelements);
            return 0;
        }
    }
}

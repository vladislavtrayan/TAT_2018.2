using System;

namespace Dev_2
{
    class Program
    {
        /// <summary>
        /// Accept a string as a param and change it's transletiration 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    ArrayToString arrayToString = new ArrayToString();
                    String initialString = String.Empty;
                    initialString = arrayToString.ConvertArrayToString(args);
                    ChangeStringTransliteration stringToTranslit = new ChangeStringTransliteration();
                    String initialStringAfterTransliteration = String.Empty;
                    initialStringAfterTransliteration = stringToTranslit.ChangeTransliteration(initialString);
                    Console.WriteLine(initialStringAfterTransliteration);
                }
                else 
                {
                    Console.WriteLine("No arguments");
                }
            }catch
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Dev_4
{
    class ListOutputter
    {
        public void Output(List<string[]> listOfString)
        {
            foreach (string[] i in listOfString)
            {
                for (int j = 0; j < i.Length - 1;j++)
                {
                    Console.Write(i[j] + " -> ");
                }
                Console.WriteLine(i[i.Length - 1]);
            }
        }
    }
}

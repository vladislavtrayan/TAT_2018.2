using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        /// <summary>
        /// Start point of program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                // example of using class Stack<String>
                String[] initialArray = new String[] { "a", "b", "c", "da","wr", "k" };
                Stack<String> InitialStack = new Stack<String>(initialArray);
                InitialStack.Pop();
                InitialStack.GetHead();
                InitialStack.Push("hello");
            }catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}

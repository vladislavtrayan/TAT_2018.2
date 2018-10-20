using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack defaultStack = new Stack();
            defaultStack.Push(1);
            defaultStack.Push(3);
            defaultStack.Resize(5);
            int[] initialArray = new int[] { 1,2,3,68,24,13};
            Stack newStackDefault = new Stack(4);
            Stack newStackRef = new Stack(initialArray);
            defaultStack.Pop();
            newStackRef.Pop();
            newStackRef.Push(11);
            newStackRef.GetHead();
        }
    }
}

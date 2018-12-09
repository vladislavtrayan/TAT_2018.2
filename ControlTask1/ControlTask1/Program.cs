using System;
using System.Text;

namespace ControlTask1
{
    struct SubLine
    {
        public StringBuilder subLine;
        public int repeatAmount;
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            StringBuilder line = new StringBuilder();
            foreach (string i in args)
            {
                line.Append(i.ToLower());
            }
            StringBuilder temporaryLine = new StringBuilder();
            temporaryLine = line;
            StringBuilder currentSubLine = new StringBuilder();
            SubLine subLine = new SubLine();
            for (int i = 0; i < temporaryLine.Length - 1; i++)
            {
                int currentNumber = 0;
                currentSubLine.Clear();
                currentSubLine.Append(temporaryLine[i]);
                currentSubLine.Append(temporaryLine[i + 1]);
                for (int j = 0; j < temporaryLine.Length; j++)
                {
                    if (currentSubLine.ToString().Equals(temporaryLine[i].ToString() + temporaryLine[i + 1].ToString()))
                    {
                        currentNumber++;
                    }
                }
                if (currentNumber > subLine.repeatAmount)
                {
                    subLine.repeatAmount = currentNumber;
                    subLine.subLine = currentSubLine;
                }
            }
            Console.WriteLine(subLine.subLine);
        }
    }
}

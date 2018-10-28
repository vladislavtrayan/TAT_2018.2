using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class Node
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string information { get; set; }
        List<string> additionalProperties;
        List<Node> includedList;
        public Node ()
        {
            additionalProperties = new List<string>();
            includedList = new List<Node>();
        }
        public void AddProperties (string line)
        {
            additionalProperties.Add(line);
        }
        public void AddNewIncludedList (Node node)
        {
            includedList.Add(node);
        }
    }
}

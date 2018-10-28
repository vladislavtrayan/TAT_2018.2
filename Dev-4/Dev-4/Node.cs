using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class Node
    {
        public bool Flag { get; set; }
        public int Depth { get; set; }
        public string Name { get; set; }
        public string information { get; set; }
        Dictionary<string,string> additionalProperties;
        List<Node> includedList;
        public Node ()
        {
            additionalProperties = new Dictionary<string, string>();
            includedList = new List<Node>();
        }
        public void AddProperties (string property,string value)
        {
            additionalProperties.Add(property, value);
        }
        public void AddNewIncludedList (Node node)
        {
            includedList.Add(node);
        }
        public void AddNewIncludedList(List<Node> newList)
        {
            includedList.AddRange(newList);
        }
        public void OutPut ()
        {
        }
    }
}

using System.Collections.Generic;

namespace Dev_4
{
    /// <summary>
    /// keeps the tag and all information that it contain
    /// </summary>
    class Node
    {
        public bool Flag { get; set; }
        public int Depth { get; set; }
        public string Name { get; set; }
        public string information { get; set; }
        Dictionary<string,string> additionalProperties;
        List<Node> includedList;
        /// <summary>
        /// class constructor
        /// </summary>
        public Node ()
        {
            additionalProperties = new Dictionary<string, string>();
            includedList = new List<Node>();
        }
        /// <summary>
        /// add new element to additional properties of each tag
        /// fill it as a dicitonary with string value and string property
        /// </summary>
        public void AddProperties (string property,string value)
        {
            additionalProperties.Add(property, value);
        }
        /// <summary>
        /// method for adding new Node to includedList
        /// </summary>
        /// <param name="node"></param>
        public void AddNewIncludedList (Node node)
        {
            includedList.Add(node);
        }
        /// <summary>
        /// method for adding new List<Node> to includedList
        /// </summary>
        /// <param name="newList"></param>
        public void AddNewIncludedList(List<Node> newList)
        {
            includedList.AddRange(newList);
        }
        /// <summary>
        /// .....
        /// </summary>
        public void OutPut ()
        {
        }
    }
}

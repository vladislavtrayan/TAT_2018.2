namespace lab_27._10._18
{
    /// <summary>
    /// Represents a list node
    /// </summary>
    class Node
    {
        public Car Data { get; set; }
        public Node NextNode { get; set; }
        public Node PreviosNode { get; set; }
        /// <summary>
        /// class constructor
        /// </summary>
        public Node()
        {
            Data = default(Car);
        }
        public Node(Car initialData)
        {
            Data = initialData;
        }
        public Node (ref Node initialNode)
        {
            Data = initialNode.Data;
        }
    }
}

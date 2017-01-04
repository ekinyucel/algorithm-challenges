namespace csharp_graphs
{
    public class Node
    {
        public Node left { get; set; }
        public Node right { get; set; }
        public int data { get; set; }

        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}

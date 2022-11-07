public class MyInteractiveLinkedLists
{

    private class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
        }
    }

    private Node First { get; set; }
    private Node Last { get; set; }
}
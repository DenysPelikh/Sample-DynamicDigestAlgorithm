namespace Algorithm.BaseCollection.BinaryTree
{
    public class BinaryNode<T>
    {
        public T Key { get; set; }
        public BinaryNode<T> LeftNode { get; set; }
        public BinaryNode<T> RightNode { get; set; }
    }
}

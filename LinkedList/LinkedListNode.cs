namespace LinkedList
{
    internal class LinkedListNode<T>
    {
        public LinkedListNode(LinkedList<T> list, T item)
        {
            List = list;
            Item = item;
        }

        public LinkedList<T> List { get; internal set; }
        public LinkedListNode<T> Next { get; internal set; }
        public T Item { get; set; }      
    }
}

using System;

namespace LinkedList
{
    public class LinkedList<T>
    { 
        private readonly LinkedListNode<T> _sentinel;
        private LinkedListNode<T> _head;
        // private LinkedListNode<T> _current;

        public LinkedList()
        {
            _sentinel = new LinkedListNode<T>(this, default(T));
            _head = _sentinel;
        }
        
        public int Length { get; private set; }

        public T Add(T item)
        {
            var result = new LinkedListNode<T>(this, item);
            _head.Next = result;
            _head = result;
            Length++;
            return result.Item;
        }

        public T AddAt(T item, int index)
        {
            ValidateIndex(index);
            var result = new LinkedListNode<T>(this, item);
            var previousNode = NodeAt(index - 1);
            result.Next = previousNode.Next;
            previousNode.Next = result;
            Length++;
            return result.Item;
        }

        public bool Remove()
        {
            if (Length == 0) return false;
            Length--;
            _head = NodeAt(Length - 1);
            _head.Next = null;
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                return false;
            }

            var previousNode = NodeAt(index - 1);
            var nodeToDelelte = previousNode.Next;
            previousNode.Next = nodeToDelelte.Next;
            return true;
        }

        public T ElementAt(int index)
        {
            ValidateIndex(index);
            var result = NodeAt(index);      
            return result.Item;
        }

        private LinkedListNode<T> NodeAt(int index)
        {
            var i = -1;
            var result = _sentinel;

            while (i++ < index)
            {
                result = result.Next;
            } 

            return result;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}

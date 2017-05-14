using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    { 
        private readonly LinkedListNode<T> _sentinel;
        private LinkedListNode<T> _lastElement;

        public LinkedList()
        {
            _sentinel = new LinkedListNode<T>(this, default(T));
            _lastElement = _sentinel;
        }

        public LinkedList(IEnumerable<T> collection) : this()
        {
            foreach (var element in collection)
            {
                Add(element);
            }
        }
        
        public int Length { get; private set; }

        public T Add(T item)
        {
            var result = new LinkedListNode<T>(this, item);
            _lastElement.Next = result;
            _lastElement = result;
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
            _lastElement = NodeAt(Length - 1);
            _lastElement.Next = null;
            Length--;
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index > Length - 1)
            {
                return false;
            }
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var previousNode = NodeAt(index - 1);
            var nodeToDelelte = previousNode.Next;
            previousNode.Next = nodeToDelelte.Next;
            Length--;
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

        public IEnumerator<T> GetEnumerator()
        {
            var current = _sentinel;
            while(current.Next != null)
            {
                current = current.Next;
                yield return current.Item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

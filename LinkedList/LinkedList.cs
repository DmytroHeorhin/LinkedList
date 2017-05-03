using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable, IEnumerator
    {
        private LinkedListNode<T> _head;
        private LinkedListNode<T> _current;
        
        public int Length { get; private set; }
        public LinkedListNode<T> Add(T item)
        {
            var result = new LinkedListNode<T>(this, item);

            if (_head == null)
            {
                _head = result;
                Length = 1;
                return result;
            }      

            
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if(_current.Next == null)
            {
                return false;
            }
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            _current = default();
        }

        private LinkedListNode<T> GetLast
        {
            
        }

        public object Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

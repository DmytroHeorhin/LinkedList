using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListNode<T>
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

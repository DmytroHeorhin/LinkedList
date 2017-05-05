using System;

namespace LinkedList.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Creating new list...");
            var list = new LinkedList<string>();
            System.Console.WriteLine("New list length: " + list.Length);
            System.Console.WriteLine("Add some items...");
            list.Add("First element");
            list.Add("Second element");
            System.Console.WriteLine("Updated list length: " + list.Length);
            System.Console.WriteLine("Element at 0 is " + list.ElementAt(0));
            System.Console.WriteLine("Element at 1 is " + list.ElementAt(1));
            System.Console.WriteLine("Add item in the middle...");
            list.AddAt("Third element", 1);
            System.Console.WriteLine("Element at 1 is " + list.ElementAt(1));
            System.Console.WriteLine("Element at 2 is " + list.ElementAt(2));
            System.Console.WriteLine("Remove some...");
            System.Console.WriteLine(list.Remove());        
            System.Console.WriteLine("Updated list length: " + list.Length);
            System.Console.WriteLine("Remove from the beginning...");
            System.Console.WriteLine(list.RemoveAt(0));
            System.Console.WriteLine("Element at 0 is " + list.ElementAt(0));
        }
    }
}

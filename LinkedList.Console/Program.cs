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


            System.Console.WriteLine("Creating new list...");
            list = new LinkedList<string>();
            System.Console.WriteLine("Add bunch of guys...");
            list.Add("1st");
            list.Add("2nd");
            list.Add("3rd");
            list.Add("4th");
            System.Console.WriteLine("Use foreach...");
            foreach (var guy in list)
            {
                System.Console.WriteLine(guy);
            }
            System.Console.WriteLine("Use foreach another time...");
            foreach (var guy in list)
            {
                System.Console.WriteLine(guy);
            }

            System.Console.WriteLine("Creating new list and use foreach...");
            list = new LinkedList<string>();
            foreach (var guy in list)
            {
                System.Console.WriteLine(guy);
            }
            System.Console.WriteLine("... and see nothing.");

            System.Console.WriteLine("Create list from collection...");
            list = new LinkedList<string>(new [] {"a", "b", "c"});
            System.Console.WriteLine("Show it...");
            foreach (var guy in list)
            {
                System.Console.WriteLine(guy);
            }
        }
    }
}

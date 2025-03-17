namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList(10);
            linkedList.AppendList(11);
            linkedList.AppendList(17);
            linkedList.AppendList(5);
            linkedList.AppendList(28);
            linkedList.Print();
            //linkedList.PrintLength();
            //linkedList.PrintHead();
            //linkedList.PrintTail();
            //linkedList.DeleteLastNode();
            //linkedList.PrintTail();

            //Console.WriteLine("Deleting last node...");
            //linkedList.DeleteLastNode2();

            //linkedList.Print();

            //Console.WriteLine("Deleting first node...");
            //linkedList.DeleteFirstNode();

            //linkedList.Print();

            //Console.WriteLine("Adding first node...");
            //linkedList.AddFirst(2);

            //linkedList.Print();

            //Console.WriteLine("Getting node...");
            //Console.WriteLine(linkedList.GetNode(2).data);

            //---------------------------------------

            //var n = linkedList.GetNode(2);
            //if (n != null)
            //{
            //    n.data = n.data + 1;
            //    Console.WriteLine(n.data);
            //}
            //else
            //    Console.WriteLine("Yanlış index");

            //-----------------------------------------

            //Console.WriteLine("Setting node...");
            //linkedList.SetNode(3, 30);
            //linkedList.Print();

            //----------------------------------------


            //Console.WriteLine("Inserting Node...");
            //linkedList.InsertNode(1, 58);
            //linkedList.Print();

            //----------------------------------------
            Console.WriteLine("Deleting Node...");
            linkedList.DeleteNode(1);
            linkedList.Print();


        }
    }
}

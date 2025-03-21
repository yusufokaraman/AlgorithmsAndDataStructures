namespace DoublyLinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AppendList(11);
            doublyLinkedList.AppendList(9);
            doublyLinkedList.AppendList(3);
            doublyLinkedList.AppendList(34);
            doublyLinkedList.AppendList(47);

            //----------------------------------------
            doublyLinkedList.Print();
            doublyLinkedList.PrintHead();
            doublyLinkedList.PrintTail();
            doublyLinkedList.PrintLength();
            //----------------------------------------

            //Console.WriteLine("*****");

            //doublyLinkedList.AppendList(22);
            //doublyLinkedList.Print();
            //doublyLinkedList.PrintTail();

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.DeleteLastNode();
            //doublyLinkedList.Print();
            //doublyLinkedList.PrintTail();
            //doublyLinkedList.PrintLength();

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.DeleteFirstNode();
            //doublyLinkedList.Print();
            //doublyLinkedList.PrintHead();
            //doublyLinkedList.PrintLength();

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.AddFirst(36);
            //doublyLinkedList.Print();
            //doublyLinkedList.PrintHead();
            //doublyLinkedList.PrintLength();

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.GetNode(3);
            //Console.WriteLine(doublyLinkedList.GetNode(3).data);

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.SetNode(3, 36);
            //Console.WriteLine(doublyLinkedList.GetNode(3).data);
            //doublyLinkedList.Print();

            //----------------------------------------

            //Console.WriteLine("**************************");
            //doublyLinkedList.InsertNode(5, 36);
            //Console.WriteLine(doublyLinkedList.GetNode(5).data);
            //doublyLinkedList.Print();

            //----------------------------------------

            Console.WriteLine("**************************");
            doublyLinkedList.DeleteNode(3);
            Console.WriteLine(doublyLinkedList.GetNode(3).data);
            doublyLinkedList.Print();
        }
    }
}

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


            doublyLinkedList.Print();
            doublyLinkedList.PrintHead();
            doublyLinkedList.PrintTail();
            doublyLinkedList.PrintLength();

            Console.WriteLine("*****");

            doublyLinkedList.AppendList(22);
            doublyLinkedList.Print();
            doublyLinkedList.PrintTail();
        }
    }
}

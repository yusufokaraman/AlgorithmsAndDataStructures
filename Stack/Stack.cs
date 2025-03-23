using System.ComponentModel.Design;

namespace Stack
{
    public class Stack
    {
        private Node top;
        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public Stack(int data)
        {
            var newNode = new Node(data);
            top = newNode;
            count = 1;
        }

        public void Push(int data)
        {
            var newNode = new Node(data);
            if (count == 0)
                top = newNode;
            else
            {
                newNode.next = top;
                top = newNode;
            }
            count++;
        }

        public void PrintAll()
        {
            Console.WriteLine("Stack içeriği:");
            Console.WriteLine("- - - - - - - -");
            Node tmp = top;

            while (tmp != null)
            {
                Console.WriteLine(tmp.data);
                tmp = tmp.next;
            }
        }

    }
}

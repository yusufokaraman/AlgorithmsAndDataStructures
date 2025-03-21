namespace DoublyLinkedLists
{
    public class DoublyLinkedList
    {
        private Node tail;
        private Node head;
        private int length;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public DoublyLinkedList(int data)
        {
            var newNode = new Node(data);
            head = newNode;
            tail = newNode;
            length = 1;
        }

        public void AppendList(int data)
        {
            var newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            length++;
        }

        public void Print()
        {
            Console.WriteLine("Doubly LinkedList içerisindeki node değerleri");
            Console.WriteLine("--------------------------------------------");
            var temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


        public void PrintLength()
        {
            Console.WriteLine($"Doubly Linked List node sayısı: {length}");
        }

        public void PrintHead()
        {
            if (head == null)
            {
                Console.WriteLine("Doubly LinkedList içerisinde veri bulunmamaktadır.");
                return;
            }

            Console.WriteLine($" Doubly Linked List head node değeri: {head.data}");
        }

        public void PrintTail()
        {
            // or tail!= null -> console.writeline(tail.data)
            if (tail == null)
            {
                Console.WriteLine("Doubly LinkedList içerisinde veri bulunmamaktadır.");
                return;
            }

            Console.WriteLine($"Doubly Linked List tail node değeri: {tail.data}");
        }

        public Node DeleteLastNode()
        {
            if (length == 0)
                return null;

            var temp = tail;

            if (length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                temp.prev = null;
            }
            length--;
             return temp;
        }

        public Node DeleteFirstNode()
        {
            if (length == 0)
                return null;

            var temp = head;

            if (length == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
                temp.next = null;
            }
            length--;
            return temp;
        }
    }
}

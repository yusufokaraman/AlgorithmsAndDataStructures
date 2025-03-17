namespace LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public LinkedList(int data)
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
                tail = newNode;
            }

            length++;
        }
        public void Print()
        {
            Console.WriteLine("LinkedList içerisindeki node değerleri");
            Console.WriteLine("--------------------------------------");
            Node temp = head;
            
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        public void PrintLength()
        {
            Console.WriteLine($"Linked List node sayısı: {length}");
        }

        public void PrintHead()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList içerisinde veri bulunmamaktadır.");
                return;
            }

            Console.WriteLine($"Linked List head node değeri: {head.data}");
        }
        public void PrintTail()
        {
            // or tail!= null -> console.writeline(tail.data)
            if (tail == null)
            {
                Console.WriteLine("LinkedList içerisinde veri bulunmamaktadır.");
                return;
            }

            Console.WriteLine($"Linked List tail node değeri: {tail.data}");
        }

        /// <summary>
        /// this code crashed because if this linked list length equal zero, code is crashing. 
        /// You should do exception handling.
        /// </summary>
        public void DeleteLastNode()
        {
            Node temp = head;
            Node lastNode = head;

            while(temp != null)
            {
                lastNode = temp;
                temp = temp.next;

                if (temp.next == null)
                {
                    tail = lastNode;
                    tail.next = null;
                    break;
                }                                   
            }
        }
       
        /// <summary>
        /// if i want to return last node
        /// </summary>
        /// <returns></returns>
        public Node DeleteLastNode2()
        {
            if (length == 0)
                return null;

            Node temp = head;
            Node lastNode = head;

            while (temp.next != null)
            {
                lastNode = temp;
                temp = temp.next;
            }

            tail = lastNode;
            tail.next = null;

            // if linkedlist contains one node, you must set manually head and tail.

            if (length == 1)
            {
                head = null;
                tail = null;
            }

            length--;
            return temp;
        }

        public Node DeleteFirstNode()
        {
            if (length == 0)
                return null;

            Node temp = head;
            head = head.next;

            temp.next = null;

            // if linkedlist contains one node, tail must be set to null manually.
            if (length == 1)
                tail = null;

            length--;
            return temp;


        }

        public void AddFirst(int data)
        {
            var newNode = new Node(data);

            if (length == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            length++;
        }

        public Node GetNode(int index)
        {
            if (index >= 0 && index < length)
            {
                Node temp = head;

                for (int i = 0; i < index; i++)
                    temp = temp.next;
                
                return temp;
            }
            else
                return null;
        }

        public void SetNode(int index, int data)
        {
            var temp = GetNode(index);

            if (temp != null)
            {
                temp.data = data;
            }
        }

        public bool InsertNode(int index, int data)
        {
            if (index < 0 || index > length)
                return false;
            else
            {
                if (index == length)
                {
                    AppendList(data);
                    return true;
                }

                if (index == 0)
                {
                    AddFirst(data);
                    return true;
                }

                var newNode = new Node(data);
                var temp = GetNode(index - 1);
                newNode.next = temp.next;
                temp.next = newNode;
                length++;
                return true;
            }
        }

        public Node DeleteNode(int index)
        {
            if (index >= 0 || index < length)
            {
                if (index == 0)
                    return DeleteFirstNode();

                if (index == length - 1)
                    return DeleteLastNode2();

                var temp = GetNode(index - 1);
                var deletedNode = GetNode(index);
                temp.next = deletedNode.next;
                deletedNode.next = null;
                length--;

                return deletedNode;
            }
            else
                return null;
        }

    }
   
}

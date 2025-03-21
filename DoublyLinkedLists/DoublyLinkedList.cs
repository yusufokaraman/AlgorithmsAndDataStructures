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
                head.prev = newNode;
                head = newNode;
            }
            length++;

        }

        public Node GetNode(int index)
        {
            if (index < 0 || index >= length)
                return null;

            var temp = head;

            if (index < length / 2)
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.next;
                }
            }
            else
            {
                temp = tail;

                for (int i = length -1; i > index; i--)
                {
                    temp = temp.prev;
                }
            }

            return temp;
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
                var temp = GetNode(index);
                var tempPrev = GetNode(index - 1);
                newNode.prev = tempPrev;
                newNode.next = temp;
                temp.prev = newNode;
                tempPrev.next = newNode;

                length++;

                return true;
            }
        }

        public Node DeleteNode(int index)
        {
            Node deletedNode = null;
            if (index >= 0 || index < length)
            {
                if (index == length - 1)
                {
                    DeleteLastNode();
                }
                else if (index == 0)
                {
                    DeleteFirstNode();
                }
                else
                {
                    //var tempPrev = GetNode(index - 1);
                    //var deletedNode = GetNode(index);
                    //var tempNext = GetNode(index + 1);

                    //tempNext.prev = tempPrev;
                    //tempPrev.next = tempNext;

                    //deletedNode.next = null;
                    //deletedNode.prev = null;

                    deletedNode = GetNode(index);
                    deletedNode.next.prev = deletedNode.prev;
                    deletedNode.prev.next = deletedNode.next;

                    deletedNode.next = null;
                    deletedNode.prev = null;

                    length--;
                }
            }
            else
                return null;

            return deletedNode;
        }
    }
}

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
    }
}

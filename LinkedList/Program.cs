namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat linked list dengan menambahkan beberapa elemen

            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Menampilkan elemen-elemen linked list

            Console.WriteLine("Isi Linked List:");
            list.Display();
        }
    }
    // Kelas Node, merepresentasikan satu elemen dalam linked list
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    // Kelas LinkedList yang berisi operasi dasar seperti Add dan Display
    public class LinkedList
    {
        private Node head;

        // Menambah elemen di akhir linked list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        // Menampilkan elemen-elemen dalam linked list
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}

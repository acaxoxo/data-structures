namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue elemen ke dalam queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // Dequeue elemen dari queue

            Console.WriteLine($"Dequeue: {queue.Dequeue()}");

            // Lihat elemen terdepan tanpa menghapus

            Console.WriteLine($"Front: {queue.Peek()}");
        }
    }
}

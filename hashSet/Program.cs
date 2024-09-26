namespace hashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HashSet adalah struktur data yang menyimpan elemen unik dan tidak terurut.

            HashSet<int> hashSet = new HashSet<int>();

            // Tambahkan elemen ke dalam Hash Set 

            hashSet.Add(10);
            hashSet.Add(20);
            hashSet.Add(30);
            hashSet.Add(20); // Duplikat, tidak akan ditambahkan

            // Tampilkan elemen Hash Set 

            foreach (int item in hashSet) {
                Console.WriteLine(item);
            }
        }
    }
}

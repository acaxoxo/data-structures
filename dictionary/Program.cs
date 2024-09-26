namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary menyimpan pasangan kunci-nilai, di mana kunci unik dan digunakan untuk mengakses nilai yang terkait.

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Tambah elemen ke Dictionary

            dictionary.Add("satu", 1);
            dictionary.Add("dua", 2);
            dictionary.Add("tiga", 3);

            // Akses nilai berdasarkan kunci

            Console.WriteLine("Nilai dari kunci 'dua': " + dictionary["dua"]);

            // Iterasi melalui dictionary

            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
        }
    }
}

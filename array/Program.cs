namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array int

            int[] angka = { 1, 2, 3, 4, 5 };

            // Akses elemen array

            Console.WriteLine($"Akses elemen pertama {angka[0]}");

            // Iterasi array

            foreach (int num in angka) {

                Console.WriteLine(num);
            };

            Console.WriteLine();
            Console.WriteLine();

            // Array string

            string[] nama = { "Nada", "Asmarani", "Cantika", "Dewi" };

            // Akses elemen array

            Console.WriteLine($"Elemen pertama {nama[0]}");

            // Mengganti elemen array

            nama[0] = "Nanda";
            Console.WriteLine($"Elemen pertama setelah diubah {nama[0]}");

            // Iterasi array

            Console.WriteLine("Daftar nama:");
            foreach (string name in nama) {

                Console.WriteLine(name);
            };

            Console.WriteLine();
            Console.WriteLine();

            // Menambahkan elemen ke array

            // Menggunakan List untuk menambah elemen secara dinamis

            List<string> namesList = new List<string> { "Shasabila", "Maharani", "Putri", "Andryka" };

            // Menambahkan elemen baru
            namesList.Add("Ruth");

            // Iterasi List
            Console.WriteLine("Daftar nama setelah penambahan:");
            foreach (string name in namesList) {

                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine();

            // Menghapus elemen dari array

            namesList.Remove("Maharani");

            // Menampilkan elemen List setelah penghapusan

            Console.WriteLine("Daftar nama setelah penghapusan:");
            foreach (string name in namesList) {

                Console.WriteLine(name);
            };

            Console.WriteLine();
            Console.WriteLine();

            // Mencari elemen dalam array

            int index = Array.IndexOf(nama, "Cantika");
            if (index != -1)
            {

                Console.WriteLine($"Cantika ditemukan pada index {index}");
            }
            else {
                Console.WriteLine("Cantika tidak ditemukan");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Contoh pencarian dalam List

            if (namesList.Contains("Andryka"))
            {

                Console.WriteLine($"Andryka ditemukan dalam List.");
            }
            else {
                Console.WriteLine("Andryka tidak ditemukan.");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Remove Element

            int[] nums = [3, 2, 2, 3];
            int val = 3;
            int k = removeElement(nums, val);
            Console.Write($"{k}, ");
            Console.Write("Array setelah dimodifikasi: ");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{nums[i]}, ");
            }
            Console.WriteLine();
        }
        public static int removeElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
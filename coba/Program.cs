using System.Text.RegularExpressions;

namespace coba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Biodata sederhana

            string nama, prodi, inputNIM;
            long nim;

            while (true)
            {
                Console.Write("Masukkan nama anda: ");
                nama = Console.ReadLine().Trim();

                if (!string.IsNullOrWhiteSpace(nama) &&
                    nama.Length >= 5 &&
                    Regex.IsMatch(nama, @"^[a-zA-Z\s]+$"))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Nama tidak boleh lebih dari 5 karakter, tidak boleh hanya berisi spasi, dan hanya boleh berisi huruf dan spasi. Silakan coba lagi.");
                }
            }
            Console.Write("Masukkan program studi anda: ");
            prodi = Console.ReadLine();
            while (true)
            {
                Console.Write("Masukkan nomor induk mahasiswa (NIM): ");
                inputNIM = Console.ReadLine();

                
                if (long.TryParse(inputNIM, out nim) && inputNIM.Length == 10)
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("NIM harus berupa angka dan minimal terdiri dari 10 digit. Silakan coba lagi.");
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Nama anda adalah {nama}");
            Console.WriteLine($"Program studi anda adalah {prodi}");
            Console.WriteLine($"Nomor induk mahasiswa anda adalah {nim}");
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace cobaLagi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Biodata sederhana
            string nama, prodi, inputNIM, inputTanggalLahir;
            long nim;
            DateTime tanggalLahir;

            for (; ; )
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
                    Console.WriteLine("Nama tidak boleh kurang dari 5 karakter. Silakan coba lagi.");
                }
            }

            Console.Write("Masukkan program studi anda: ");
            prodi = Console.ReadLine();

            for (; ; )
            {
                Console.Write("Masukkan nomor induk mahasiswa (NIM): ");
                inputNIM = Console.ReadLine();

                if (long.TryParse(inputNIM, out nim) && inputNIM.Length == 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("NIM harus berupa angka dan terdiri dari 10 digit. Silakan coba lagi.");
                }
            }

            for (; ; )
            {
                Console.Write("Masukkan tanggal lahir anda (dd-mm-yyyy): ");
                inputTanggalLahir = Console.ReadLine().Trim();

                if (DateTime.TryParseExact(inputTanggalLahir, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out tanggalLahir))
                {
                    if (CekValiditasTanggal(tanggalLahir))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tanggal yang anda masukkan tidak valid. Silakan coba lagi.");
                    }
                }
                else
                {
                    Console.WriteLine("Format tanggal lahir salah. Gunakan format dd-mm-yyyy.");
                }
            }

            int umur = HitungUmur(tanggalLahir);

            Console.WriteLine();
            Console.WriteLine($"Nama anda adalah {nama}");
            Console.WriteLine($"Program studi anda adalah {prodi}");
            Console.WriteLine($"Nomor induk mahasiswa anda adalah {nim}");
            Console.WriteLine($"Tanggal lahir anda adalah {tanggalLahir.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Umur anda adalah {umur} tahun");
        }

        static int HitungUmur(DateTime tanggalLahir)
        {
            DateTime today = DateTime.Now;
            int umur = today.Year - tanggalLahir.Year;

            if (tanggalLahir > today.AddYears(-umur))
            {
                umur--;
            }

            return umur;
        }

        static bool CekValiditasTanggal(DateTime tanggal)
        {
            int hari = tanggal.Day;
            int bulan = tanggal.Month;

            if (bulan == 1 || bulan == 3 || bulan == 5 || bulan == 7 || bulan == 8 || bulan == 10 || bulan == 12)
            {
                return hari <= 31;
            }
            
            else if (bulan == 4 || bulan == 6 || bulan == 9 || bulan == 11)
            {
                return hari <= 30;
            }
            
            else if (bulan == 2)
            {
                bool tahunKabisat = DateTime.IsLeapYear(tanggal.Year);
                return tahunKabisat ? hari <= 29 : hari <= 28;
            }

            return false; 
        }
    }
}
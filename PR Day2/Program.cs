using System;
using System.Security.Cryptography.X509Certificates;

namespace PR_Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================PR DAY 2================");
            Console.WriteLine("1. Progaram Menentukan Grade");
            Console.WriteLine("2. Progam Mengecek Ganjil Atau genap");

            Console.WriteLine("Masukkan Pilihan Anda : ");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("=================Program Menentukan Grade=================");
                    Console.WriteLine("Masukkan Nilai Anda :");
                    int nilai = int.Parse(Console.ReadLine());

                    if (nilai >= 80)
                    {
                        Console.WriteLine("A");
                    }
                    else if (nilai >= 60)
                    {
                        Console.WriteLine("B");
                    }
                    else if (nilai <= 60)
                    {
                        Console.WriteLine("C");
                    }
                    break;


                case 2:
                    Console.WriteLine("=================Program Mengecek Ganjil atau Genap=================");
                    Console.WriteLine("Masukkan Angka yang ingin di Cek : ");
                    int input = int.Parse(Console.ReadLine());
                    Cekgenap(input) ?
                        Console.WriteLine($"angkat {input} = ganjil "): Console.WriteLine($"angkat {input} = ganjil ");
                    }
                    break;
                case 3:
                    Console.WriteLine("Pilihan ke tiga");
                    break;
                default:
                    Console.WriteLine("Anda memilih yang lain ");
                    break;
            }



        public static bool Cekgenap(int x)
        {
            if (x % 2 == 0)
            { return true; }
            else
            { return false; }


        }
    }
        
    }
}

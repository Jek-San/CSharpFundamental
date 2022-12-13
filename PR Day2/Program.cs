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
            Console.WriteLine("3. PRogram ");
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
                    Console.Write("Masukkan Angka yang ingin di Cek : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Angka {x} = {Cekgenap(x)}");

                    break;
                case 3:
                    Console.WriteLine("Program Diskon Grabfood");
                    Console.Write("Masukkan Jumlah Belanja anda : ");
                    int belanja = int.Parse(Console.ReadLine());
                    Console.Write("Jarak : ");
                    int jarak = int.Parse(Console.ReadLine());

                    Console.Write("Masukkan promo : ");
                    string kode = Console.ReadLine();
                    var dsc = ValidasiDiskon(kode);
                    Console.WriteLine("====================================");
                    Console.WriteLine($"Belanja : {belanja}");


                    Console.WriteLine($"Diskon : {Diskon(belanja, belanja)}");

                    Console.WriteLine($"Onkir : {Ongkir(jarak)}");
                    Console.WriteLine($"Total Belanja: {TotalBelanja(belanja, Ongkir(jarak), Diskon(belanja, belanja))} ");


                    break;
                default:
                    Console.WriteLine("Anda memilih yang lain ");
                    break;
            }



            static string Cekgenap(int x)
            {
                return x % 2 == 0 ? "Genap" : "Ganjil";

            }

            static bool ValidasiDiskon(string x)
            {

                return x == "JKTOVO" ? true : false;

            }

            static double Diskon(double x, double belanja)
            {

                return x = belanja >= 30000 ? (30000 * 0.4) : belanja * 0.4;
            }


        }
        static int Ongkir(int x)
        {

            return x >= 5 ? 5000 + ((x - 5) * 1000) : 5000;
        }
        static double TotalBelanja(int x, int y, double z)
        {
            return (x + y + z);
        }
    }

}


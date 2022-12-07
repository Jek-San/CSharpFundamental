using System;
using System.Linq.Expressions;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool repeatMenu = true;
            do
            {
                Console.WriteLine(" Soal 1. Diskon Sopi ");
                Console.WriteLine(" Soal 2. Cek Generasi ");
                Console.WriteLine(" Soal 3. ");

                Console.Write("Masukkan Pilihan Menu Soal: ");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Soal 1");
                        Soal1();
                        break;
                    case 2:
                        Console.WriteLine("Soal 2");
                        Soal2();
                        Console.Write("Apakah anda ingin mencoba lagi? Y/N ");
                        string cobaLagi = Console.ReadLine();
                        if (cobaLagi == "y")
                        {
                            repeatMenu = true;
                            Console.Clear();
                            
                        }
                        else { repeatMenu = false; }

                        break;
                    case 3:
                        Console.WriteLine("Soal 3");

                        break;
                    default:
                        Console.WriteLine("Anda memilih yang lain ");
                        break;
                }
            } while (repeatMenu);
           
        }

        public static void Soal1()
        {
            Console.WriteLine("List Voucher Shoppw");
            Console.WriteLine("1.  Min Order 30 rb free onglir 5rb");
            Console.WriteLine("2.  Min Order 50 rb free onglir 10rb");
            Console.WriteLine("3.  Min Order 100 rb free ongkir 10rb");

            Console.Write("Belanja       : ");
            double belanja = int.Parse(Console.ReadLine());
            Console.Write("Ongkir Kirim  : ");
            int onkir = int.Parse(Console.ReadLine());
            Console.Write("Pilih Voucher : ");
            int voucher = int.Parse(Console.ReadLine());

            switch (voucher)
            {
                case 1:
                    Console.WriteLine("Pilihan pertama");
                    Console.WriteLine($"Belanja        : {belanja}");


                    Console.WriteLine($"Ongkos Kirim   : {onkir}");

                    Console.Write("Diskon Ongkir  : ");
                    if (belanja >= 30000)
                    {
                        onkir = onkir - 5000;
                    }
                    else
                    {
                        onkir = onkir + 0;
                    }
                    Console.WriteLine(onkir);
                    double diskon = 0.0;
                    Console.Write("Diskon Belanja : ");
                    if (belanja >= 30000)
                    {
                        diskon = 5000;
                        belanja = belanja - 5000;
                    }
                    else
                    {
                        diskon = 0;
                    }
                    Console.WriteLine($"{diskon}");

                    Console.Write(" Total Belanja : ");
                    double totalBelanja = 0.0;
                    totalBelanja = belanja - diskon - onkir;
                    Console.WriteLine(totalBelanja);

                    break;
                case 2:
                    Console.WriteLine("Pilihan kedua");
                    Console.WriteLine($"Belanja        : {belanja}");


                    Console.WriteLine($"Ongkos Kirim   : {onkir}");

                    Console.Write("Diskon Ongkir  : ");
                    if (belanja >= 50000)
                    {
                        onkir = onkir - 10000;
                    }
                    else
                    {
                        onkir = onkir + 0;
                    }
                    Console.WriteLine(onkir);
                    diskon = 0.0;
                    Console.Write("Diskon Belanja : ");
                    if (belanja >= 50000)
                    {
                        diskon = 5000;
                        belanja = belanja - 10000;
                    }
                    else
                    {
                        diskon = 0;
                    }
                    Console.WriteLine($"{diskon}");

                    Console.Write(" Total Belanja : ");
                    totalBelanja = 0.0;
                    totalBelanja = belanja - diskon - onkir;
                    Console.WriteLine(totalBelanja);
                    break;
                case 3:
                    Console.WriteLine("Pilihan ke tiga");
                    Console.WriteLine($"Belanja        : {belanja}");


                    Console.WriteLine($"Ongkos Kirim   : {onkir}");

                    Console.Write("Diskon Ongkir  : ");
                    if (belanja >= 100000)
                    {
                        onkir = onkir - 20000;
                    }
                    else
                    {
                        onkir = onkir + 0;
                    }
                    Console.WriteLine(onkir);
                    diskon = 0.0;
                    Console.Write("Diskon Belanja : ");
                    if (belanja >= 50000)
                    {
                        diskon = 5000;
                        belanja = belanja - 10000;
                    }
                    else
                    {
                        diskon = 0;
                    }
                    Console.WriteLine($"{diskon}");

                    Console.Write(" Total Belanja : ");
                    totalBelanja = 0.0;
                    totalBelanja = belanja - diskon - onkir;
                    Console.WriteLine(totalBelanja);
                    break;
                default:
                    break;
            }
        }

        public static void Soal2()
        {
            string generasi;
            Console.WriteLine("Program Mengetahui Generasi sesuai Usia");
            Console.Write("Masukkan nama Anda : ");
            string nama = Console.ReadLine();
            Console.Write("Tahun berapa anda lahir : ");
            int tahun = int.Parse(Console.ReadLine());
            if (tahun >= 1944 && tahun <= 1964)
            {
                generasi = "Generasi X";
            }
            else if (tahun >= 1965 && tahun <= 1979)
            {
                generasi = "Generasi Y (Millenials)";
            }
            else if (tahun >= 1995 && tahun <= 2015)
            {
                generasi = "Generasi Z";
            }
            else
            {
                generasi = "Anda tidak berada digenrasi manapun";
            }
            Console.WriteLine($"{nama}, berdasarkan generasi anda tergolong {generasi} ");
        }

        public static void Soal3()
        {
            Console.WriteLine("Program Cetak Slip Gaji");
            Console.WriteLine("\n");
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
        }
        


    }
}

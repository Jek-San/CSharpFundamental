using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Soaltambahan_setelahlogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soal No :");
            int pil = int.Parse(Console.ReadLine());

            switch (pil)
            {
                case 8:
                    Console.WriteLine("Kpk dan pertemuan selanjutnya");
                    Soal8();
                    break;
                case 1:
                    Console.WriteLine("Total list besar dan reverse list");
                    Soal1();
                    break;
                case 2:
                    Console.WriteLine("Total Kue  ");
                    Soal2();
                    break; 
                case 3:
                    Console.WriteLine("Jumlah Balonn Promo");
                    Soal3();
                    break;
                case 4:
                    Console.WriteLine("Array pembanding");
                    Soal4();
                    break;
                default:
                    break;
            }



        }

        public static void Soal8()
        {

            Console.Write("Ïnput x :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ïnput y :");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Tanggal Pertemuan terakhir");
            DateTime date = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("id-ID"));
            Console.WriteLine(date);
            bool checker = false;
            int kpk = x;
            while (checker == false)
            {
                if (kpk % x == 0 && kpk % y == 0)
                {
                    checker = true;

                }
                else
                {
                    kpk++;
                }
            }
            Console.WriteLine($"{kpk}");
            
            Console.WriteLine(date.AddDays(kpk));


        }
        public static void Soal1()
        {
            int temp;
            List<int> totalBesar = new List<int>();
            List<int> totalKecil = new List<int>();
            
            Console.WriteLine("===================");
            Console.Write("Input :");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            int[] inputInt = Array.ConvertAll(inputSplit, int.Parse);
            Array.Sort(inputInt);

            for (int i = 0; i < 3; i++)
            {
                temp = inputInt[i];
                totalBesar.Add(temp);
            }
            totalBesar.Sum();
            Array.Reverse(inputInt);
            for (int i = 0; i < 3; i++)
            {
                temp = inputInt[i];
                totalKecil.Add(temp);
            }
            totalKecil.Sum();
            foreach (var item in totalBesar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(totalBesar.Sum());
            Console.WriteLine(totalKecil.Sum());
                


        }
        public static void Soal2()
        {

            Console.WriteLine("Input n :");
            int n =  int.Parse(Console.ReadLine());
            
            double terigu = 115.0 / 15.0;
            double gulaPasir = 190.0 / 15.0;
            double susu = 100.0 / 15.0;

            Console.WriteLine($"Berikut adalah resept untuk membuat {n} Kue Pukis adalah");
            Console.WriteLine($"{n * terigu}gr terigu");
            Console.WriteLine($"{n * gulaPasir}gr gulapasir");
            Console.WriteLine($"{n * susu}ml Susu");


        }
        public static void Soal3()
        {
            Console.WriteLine("Input Duit : ");
            string input = Console.ReadLine();
            int inputInt = int.Parse(input);
            int balon = 2000;
            Console.WriteLine(inputInt);
            int jml = inputInt / balon;
            if (jml > 5)
            {
                jml += 1;
            }
            Console.WriteLine($"Jumlah balon yang Monda beli adalah {jml}");

        }
        public static void Soal4()
        {
            Console.WriteLine("Input arr : ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            string inputString = string.Join("", inputSplit);
            string temp;
            List<char> cetak = new List<char>();
            Console.WriteLine(inputString);
            string pembanding = "4,5,6,7";
            string[] pembandingSplit = pembanding.Split(',');
            string pembandingString = string.Join("", pembandingSplit);
            int index;
            int b = 0;
            for (int i = 0; i < pembandingString.Length; i++)
            {
                index = inputString.IndexOf(pembandingString[i]);
                if (index != -1)
                {
                    cetak.Add(inputString[index]);

                }
            }
            string cetak1 = string.Join(", ", cetak);
            Console.WriteLine(cetak1);


        }
        public static void Soal5()
        {

            Console.WriteLine("Input arr : ");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            string inputString = string.Join("", inputSplit);
            string temp;
            List<char> cetak = new List<char>();
            List<char> penampung = new List<char>();

            Console.WriteLine(inputString);
            string pembanding = "4,5,6,7";
            string[] pembandingSplit = pembanding.Split(',');
            string pembandingString = string.Join("", pembandingSplit);
            int index;
            int b = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                index = pembandingString.IndexOf(inputString[i]);
                if (index == -1)
                {
                    cetak.Add(inputString[i]);

                }
            }
            for (int j = 0; j < pembandingString.Length; j++)
            {
                index = inputString.IndexOf(pembandingString[j]);
                if (index == -1)
                {
                    cetak.Add(pembandingString[j]);

                }
            }
            string cetak1 = string.Join("", cetak);
            Console.WriteLine(cetak1);


        }
        public static void Soal6()
        {
            Console.Write("Input P = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Input d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Input m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input s = ");
            int s = int.Parse(Console.ReadLine());
            List<int> total = new List<int>();
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"s = {s}");
            int sisaUang;

            for (int i = p; i >= m; i = i - d)
            {
                if (total.Sum() <= s)
                {
                    total.Add(i);
                }
            }
            sisaUang = s - total.Sum();
            if (sisaUang >= m)
            {
                while (sisaUang >= m)
                {
                    total.Add(m);
                    sisaUang = s - total.Sum();
                }
            }
            string cetak = string.Join("+", total);
            Console.WriteLine(cetak);
            Console.WriteLine($"list Total = {total.Sum()}");
            Console.WriteLine($"Total game = {total.Count()}");


        }
        public static void Soal7()
        {
            int total = 1;
            Console.Write("Input N = ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                total = total * i;
            }
            Console.WriteLine($"ada {total} cara");


        }
        public static void Soal9()
        {
            Console.Write("Input P = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Input d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Input m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Input s = ");
            int s = int.Parse(Console.ReadLine());
            List<int> total = new List<int>();
            Console.WriteLine($"p = {p}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"m = {m}");
            Console.WriteLine($"s = {s}");
            int sisaUang;

            for (int i = p; i >= m; i = i - d)
            {
                if (total.Sum() <= s)
                {
                    total.Add(i);
                }
            }
            sisaUang = s - total.Sum();
            if (sisaUang >= m)
            {
                while (sisaUang >= m)
                {
                    total.Add(m);
                    sisaUang = s - total.Sum();
                }
            }
            string cetak = string.Join("+", total);
            Console.WriteLine(cetak);
            Console.WriteLine($"list Total = {total.Sum()}");
            Console.WriteLine($"Total game = {total.Count()}");


        }








    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PR_Day8
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Soal 1. Julius Caesar ");
                Console.WriteLine(" Soal 2. A");
                Console.WriteLine(" Soal 3 ");
                Console.WriteLine(" Soal 4 ");
                Console.WriteLine(" Soal 5 ");
                Console.WriteLine();
                Console.WriteLine(" 6. Exit ");


                Console.Write("Masukkan Pilihan Menu Soal: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Soal1();
                        break;
                    case 2:
                        Soal2();
                        break;
                    case 3:
                        Soal3();
                        break;
                    case 4:
                        Soal4();
                        break;
                    case 5:
                        Soal5();
                        break;
                    default:
                        Console.WriteLine("Anda memilih yang lain ");
                        break;
                }
            } while (menu != 6);



        }
        static void Soal1()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("beautifulDays");
                Console.WriteLine("=============\n");
                Console.Write("I = ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("J = ");
                int j = int.Parse(Console.ReadLine());
                Console.Write("K = ");
                int k = int.Parse(Console.ReadLine());
                List<int> hari = new List<int>();
                List<int> pembalik = new List<int>();
                List<int> hariCantik = new List<int>();
                char[] penampung;
                double penampungDouble;

                for (int b = i; b <= j; b++)
                {
                    hari.Add(b);
                    penampung = b.ToString().ToCharArray();
                    penampung = penampung.Reverse().ToArray();
                    pembalik.Add(int.Parse(penampung));
                }

                List<double> hariIndah = new List<double>();
                for (int c = 0; c < hari.Count; c++)
                {
                    penampungDouble = ((hari[c] - pembalik[c]) / k);
                    if ((hari[c] - pembalik[c]) % k == 0)
                    {
                        hariCantik.Add(hari[c]);
                    }


                }

                string cetak = string.Join(" dan ", hariCantik);
                Console.WriteLine($"Hari Cantik itu pada tanggal : {cetak}");








                /*                Console.WriteLine("ini Hari");
                                foreach (var item in hari)
                                {
                                    Console.Write(item);
                                }

                                Console.WriteLine();

                                    Console.WriteLine("Ïni pembalik");
                                foreach (var item in pembalik)
                                {
                                    Console.Write(item);
                                }


                                Console.WriteLine();



                */


                Console.ReadLine();


                Console.ReadLine();
            } while (ulang);
        }

        static void Soal2()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.Write("Panjang Array : ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Masukkan niali arr : ");
                string[] nilArr = Console.ReadLine().Split(" ");
                List<int> nilArrInt = Array.ConvertAll(nilArr, int.Parse).ToList();
                int length = nilArrInt.Count;
                List<int> output = new List<int>();
                output.Add(length);
                foreach (var item in nilArrInt)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(nilArrInt.Min());
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {

                    int min = nilArrInt.Min();

                    for (int j = 0; j < nilArrInt.Count; j++)
                    {

                        nilArrInt[j] = nilArrInt[j] - min;
                        Console.Write($"{nilArrInt[j]} ");
                        if (nilArrInt[j] == 0)
                        {
                            nilArrInt.RemoveAt(j);
                            j--;
                        }


                    }
                    if (nilArrInt.Count == 0)
                    {
                        break;
                    }
                    length = nilArrInt.Count;
                    Console.WriteLine();
                    output.Add(length);

                    // Console.WriteLine(count);
                }
                Console.Write("Output :");
                foreach (var item in output)
                {
                    Console.Write($"{item} ");
                }
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal3()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                


                Console.ReadLine();
            } while (ulang);
        }
        static void Soal4()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal5()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
               


                Console.ReadLine();
            } while (ulang);
        }





    }
}

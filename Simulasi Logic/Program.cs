﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Simulasi_Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soal No :");
            int pil = int.Parse(Console.ReadLine());

            switch (pil)
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
                case 6:
                    Soal6();
                    break;
                case 7:
                    Soal7();
                    break;
                case 8:
                    Soal8();
                    break;
                case 9:
                    Soal9();
                    break;
                default:
                    break;
            }
        }

        static void Soal1()
        {
            Console.WriteLine("Input : ");
            char[] input = Console.ReadLine().ToCharArray();
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 'A' && input[i] <'Z')
                {
                    count++;
                }
            }


            int output = count;


            Console.WriteLine($"Output : {output}");
        }

        static void Soal2()
        {
            Console.Write("Start = ");
            int start = int.Parse(Console.ReadLine());  
            Console.Write("End = ");
            int end = int.Parse(Console.ReadLine());

            string InisialPer = "XA";
            DateTime tanggal = DateTime.Now;
            string tgl = tanggal.ToString();

            List<int> listInvoice = new List<int>();
            List<int> penampung = new List<int>();

            List<string> output = new List<string>();
            Console.WriteLine();

            output.Add(InisialPer);
            output.Add(tgl);

            for (int i = start; i <= end; i++)
            {
               penampung.Add(i);
               int test = penampung[i];
               listInvoice.Add(test);

            }





        }

        static void Soal3()
        {
            Console.WriteLine("Kerangjang 1 : ");
            int keranjang1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Keranjang 2 :");
            int keranjang2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Keranjang 3 :");
            int keranjang3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Keranjang yang dibawa kepasar :");
            int take = int.Parse(Console.ReadLine());
            int output = 0;

            if (take == 1)
            {
                output = keranjang2 + keranjang3;
            }
            else if (take == 2)
            {
                output = keranjang1 + keranjang3;
            }
            else if (take == 3)
            {
                output = keranjang1 + keranjang2;
            }
            Console.WriteLine($"Sisa Buah : {output}");


        }

        static void Soal4()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Laki Dewasa");
            Console.WriteLine("2. Wanita Dewasa");
            Console.WriteLine("3. Anak-anak");
            Console.WriteLine("4. Bayi\n\n");

            Console.WriteLine("Input baju untuk : ");
            int pilihan = int.Parse(Console.ReadLine());
            bool ulang = true;
            string lagi;
            do
            {
                switch (pilihan)
                {

                    case 1:
                        Console.WriteLine("Laki Laki Dewasa =");
                        int lakiDewasa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingin input lagi? y/n");
                        lagi = Console.ReadLine();
                        if (lagi == "y")
                        {
                            ulang = true;
                        }
                        else
                        {
                            ulang = false;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Wanita Dewasa =");
                        int wanitaDewasa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingin input lagi? y/n");
                        lagi = Console.ReadLine();
                        if (lagi == "y")
                        {
                            ulang = true;
                        }
                        else
                        {
                            ulang = false;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Anak-anak =");
                        int anak2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingin input lagi? y/n");
                        lagi = Console.ReadLine();
                        if (lagi == "y")
                        {
                            ulang = true;
                        }
                        else
                        {
                            ulang = false;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Bayi =");
                        int bayi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingin input lagi? y/n");
                        lagi = Console.ReadLine();
                        if (lagi == "y")
                        {
                            ulang = true;
                        }
                        else
                        {
                            ulang = false;
                        }
                        break;
                    default:
                        break;
                }
            } while (true);

            Console.WriteLine("Data yang terinput : ") ;
            Console.WriteLine($"Laki kali dewasa : ");
            

            
            
        }

        static void Soal5()
        {
            Console.WriteLine("Input : ");
            string nilai = Console.ReadLine();
            string[] nilaiSplit = nilai.Split(", ");
            int[] nilaiInt = Array.ConvertAll(nilaiSplit, int.Parse);
            List<int> listPenampung = new List<int>();
           
            for (int i = 0; i < nilaiInt.Length; i++)
            {
                if (nilaiInt[i] >35)
                {
                    
                    for (int j = 0; j < 5; j++)
                    {
                           int test = nilaiInt[i] + j ;
                        if (test%5==0)
                        {
                            listPenampung.Add(test);
                            break;
                        }
                        
                    }
                }
                else
                {
                    listPenampung.Add(nilaiInt[i]);
                }
            }

            Console.WriteLine("Ouput : ");
            foreach (var item in listPenampung)
            {
                Console.WriteLine(item);
            }
        }

        static void Soal6()
        {
            bool checker;
            Console.WriteLine("Input = ");
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            string alpabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < input.Length; i++)
            {
                int index = alpabet.IndexOf(input[i]);
                if (index == -1)
                {
                    checker = false;
                }
            }

            Console.Write("Output :");
            if (checker = true)

            {
                Console.WriteLine("Kalimat ini adalah pangram");
            }
            else
            {
                Console.WriteLine("Kalimat ini bukan pangram");
            }
        }

        static void Soal7()
        {
            Console.WriteLine("Input : Masukkan maksimal himpunan :");
            int batas = int.Parse(Console.ReadLine());
            List<int> fibo = new List<int>();
            List<int> genap = new List<int>();
            List<int> ganjil = new List<int>();
            fibo.Add(1);
            fibo.Add(1);
            int temp;

            for (int i = 0; i < batas-2; i++)
            {
                temp = fibo[i] + fibo[i+1];
                fibo.Add(temp);
            }

            for (int i = 2; i <= batas*2; i=i+2)
            {
                genap.Add(i);
            }

            for (int i = 1; i <= batas*2; i+=2)
            {
                ganjil.Add(i);
            }

            string cetakFibo = string.Join(",",fibo);
            string cetakGenap= string.Join(",", genap);
            string cetakGanjil = string.Join(",", ganjil);

            Console.WriteLine($"Fibonacci : {cetakFibo}   sum = {fibo.Sum()}             avg = {(double)fibo.Sum()/(double) fibo.Count}");
            Console.WriteLine($"Genap : {cetakGenap}      sum = {genap.Sum()}            avg = {genap.Sum() / genap.Count}");
            Console.WriteLine($"Ganjil : {cetakGanjil}    sum = {ganjil.Sum()}           avg = {ganjil.Sum() / ganjil.Count}");



        }

        static void Soal8()
        {
            Console.WriteLine("Input : ");
            string[] input = Console.ReadLine().Split(",");
            int batas = int.Parse(input[1]);
            char[] rekursif = input[0].ToCharArray();
            List<int> list = new List<int>();
            

            for (int i = 0; i < batas; i++)
            {
                for (int j = 0; j < rekursif.Length; j++)
                {
                            list.Add(j);
                }
            }

            int temp = list.Sum();
            
            if (temp >= 10)
            {
                char[] penampung = temp.ToString().ToCharArray();
                for (int i = 0; i < penampung.Length; i++)
                {
                    for (int j = 0; j < penampung.Length; j++)
                    {
                        list.Add(j);
                    }
                }
            }
            Console.WriteLine($"Ouput : {list.Sum()}" );
        }

        static void Soal9()
        {
            Console.WriteLine("Beli Pulsa = ");
            double pulsa = int.Parse(Console.ReadLine());
            double point=0;
            if (pulsa > 10000 && pulsa< 30000)
            {
                point = pulsa / 1000;
                Math.Floor(point);
            }
            else if (pulsa > 30000)
            {
                point = pulsa / 500;
                Math.Floor(point);
            }
            Console.WriteLine($"Output : {point}");
        }

        static void Soal10()
        {
            Console.WriteLine("Input Selisih : ");
            int selisih = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Array   : ");
            string arr = Console.ReadLine();
            string[] arr2 = arr.Split(' ');
            int[] arrInt = Array.ConvertAll(arr2, int.Parse);

            for (int i = 0; i < arrInt.Length; i++)
            {
                for (int j = 0; j < arrInt.Length-1; j++)
                {
                    Console.WriteLine("Done");
                }
            }

        }
    }
}

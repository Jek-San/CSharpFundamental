using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Soal 1. Pohon Faktor ");
                Console.WriteLine(" Soal 2 ");
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
                Console.Write("Input : ");
                string input = Console.ReadLine();
                Console.Write("rotate =");
                int rot = int.Parse(Console.ReadLine());
                char[] inputChr = input.ToCharArray();
                int pengubah;
                int c = inputChr[0] + 2;
                char something;
                /* Console.WriteLine(c);
                 Console.WriteLine(somthing);*/

                for (int i = 0; i < inputChr.Length; i++)
                {
                    if (inputChr[i] == '-')
                    {
                        continue;
                    }
                    //condition huruf kecil
                    else if (inputChr[i] >= 97 && inputChr[i] <= 122)
                    {
                        if (inputChr[i] + rot >= 122)
                        {
                            pengubah = inputChr[i] + rot - 26;
                            something = (char)pengubah;
                            inputChr[i] = something;
                        }
                        else
                        {
                            pengubah = inputChr[i] + rot;
                            something = (char)pengubah;
                            inputChr[i] = something;
                        }
                    }
                    else if (inputChr[i] >= 65 && inputChr[i] <= 90)
                    {
                        if (inputChr[i] + rot >= 90)
                        {
                            pengubah = inputChr[i] + rot - 26;
                            something = (char)pengubah;
                            inputChr[i] = something;
                        }
                        else
                        {
                            pengubah = inputChr[i] + rot;
                            something = (char)pengubah;
                            inputChr[i] = something;
                        }
                    }
                    /* pengubah = inputChr[i]+rot;
                             something = (char) pengubah;*/
                    //inputChr[i] = something;
                    //  }
                }
                string cetak = string.Join("", inputChr);
                Console.WriteLine(cetak);

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








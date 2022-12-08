using System;
using System.Diagnostics.Tracing;

namespace Day4
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                int menu= 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine(" Soal 1. Pohon Faktor ");
                    Console.WriteLine(" Soal 2  ");
                    Console.WriteLine(" Soal 3 ");
                    Console.WriteLine(" Soal 4 ");
                    Console.WriteLine(" Soal 5 ");
                    Console.WriteLine(" Soal 6 ");
                    Console.WriteLine(" Soal 7 ");

                Console.WriteLine(" 8. Exit ");


                    Console.Write("Masukkan Pilihan Menu Soal: ");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Soal1();

                            /*if (cobaLagi == "y")
                            {
                                repeatMenu = true;


                            }
                            else { repeatMenu = false; }*/
                            break;
                        case 2:
                            Soal2();
                            /*Console.Clear();
                            Console.WriteLine("Soal 2");
                            Console.Write("Apakah anda ingin mencoba lagi? Y/N ");
                            cobaLagi = Console.ReadLine();
                            if (cobaLagi == "y")
                            {
                                repeatMenu = true;


                            }
                            else { repeatMenu = false; }
*/
                            break;
                        case 3:
                             Soal3();
                            /* Console.Clear();
                             Console.WriteLine("Soal 3");
                             cobaLagi = Console.ReadLine();
                             if (cobaLagi == "y")
                             {
                                 repeatMenu = true;


                             }
                             else { repeatMenu = false; }*/
                            break;
                    case 4:
                        Soal4();
                        /* Console.Clear();
                         Console.WriteLine("Soal 4");
                         Console.Write("Apakah anda ingin mencoba lagi? Y/N ");

                         cobaLagi = Console.ReadLine();
                         if (cobaLagi == "y")
                         {
                             repeatMenu = true;


                         }
                         else { repeatMenu = false; }*/
                        break;
                    case 5:
                        Soal5();
                        /* Console.Clear();
                         Console.WriteLine("Soal 4");
                         Console.Write("Apakah anda ingin mencoba lagi? Y/N ");

                         cobaLagi = Console.ReadLine();
                         if (cobaLagi == "y")
                         {
                             repeatMenu = true;


                         }
                         else { repeatMenu = false; }*/
                        break;
                    case 6:
                        Soal6();
                        Console.ReadLine();
                        /* Console.Clear();
                         Console.WriteLine("Soal 4");
                         Console.Write("Apakah anda ingin mencoba lagi? Y/N ");

                         cobaLagi = Console.ReadLine();
                         if (cobaLagi == "y")
                         {
                             repeatMenu = true;


                         }
                         else { repeatMenu = false; }*/
                        break;
                    case 7:
                        Soal7();
                        Console.ReadLine();
                        /* Console.Clear();
                         Console.WriteLine("Soal 4");
                         Console.Write("Apakah anda ingin mencoba lagi? Y/N ");

                         cobaLagi = Console.ReadLine();
                         if (cobaLagi == "y")
                         {
                             repeatMenu = true;


                         }
                         else { repeatMenu = false; }*/
                        break;
                    default:
                            Console.WriteLine("Anda memilih yang lain ");
                            break;
                    }
                } while (menu != 8);
            }

        

        static void Soal1()
        {
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while (n>1)
            {
                if (n%i == 0)
                {
                    Console.WriteLine($"{n}/{i} = {n / i}");
                    n = n / i;
                }
                else
                {
                    i++;
                }
            }
            Console.ReadLine();
           
        }
        static void Soal2()
        {
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            int pembalik = n;
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                    if (i == 1)
                    {
                        Console.Write($"{j} ");

                    }
                    else if (i==n)
                    {
                        Console.Write($"{pembalik} ");
                        pembalik = pembalik - 1;

                    }
                    else if (j==1 || j==n)
                    {
                        Console.Write($"* ");
                    }
                    else
                    {
                    Console.Write("  ");

                    }


                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
            
        static void Soal3()
        {
            Console.Clear();
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double angka = Math.Pow(3, i);
                if (i%2 != 0)
                {

                Console.Write($"{angka} ");
                }
                else { Console.Write("* "); }
            }
            Console.ReadLine();
        }
        static void Soal4()
        {
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            int angka = 1;
            for (int i = 1; i <= n; i++)
            {
                if(i%3 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                Console.Write($"{angka} ");
                angka = angka + 4;

                }
            }
            Console.ReadLine();
        }
        static void Soal5()

        {
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            int angka = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                    angka = angka + 4;

                }
                else
                {
                Console.Write($"{angka} ");
                angka = angka + 4;

                }
            }
            Console.ReadLine();
        }
        static void Soal6()
        {
            Console.Write("Input : ");
            int n = int.Parse(Console.ReadLine());
            int nilai = 1;
            int nilai2 = 1;
            int temp = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (i == 0) Console.Write($"{nilai},");
                else if (i == 1) Console.Write($"{nilai2},");
                else if (i == n - 1)
                {
                    Console.Write($"{nilai + nilai2}");
                }
                else
                {
                    Console.Write($"{nilai + nilai2},");
                    temp = nilai;
                    nilai = nilai + nilai2;
                    nilai2 = temp;
                }
                
               

                
            }
        }
        static void Soal7()
        {
            Console.Write("Input : ");
            string n = Console.ReadLine();
            int panjangKata = n.Length;
            int error = 0;
            for (int i = 0; i < panjangKata; i+=3)
            {
                if (n.Substring(i,3))
                {
                    error++;
                   
                }
            }
            Console.WriteLine($"Sinyal yang diterima : {n}");


        }
    }
}

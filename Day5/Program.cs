using System;
using System.Text;

namespace Day5
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
                Console.WriteLine(" Soal 2  ");
                Console.WriteLine(" Soal 3 ");
                Console.WriteLine(" Soal 4 ");
                Console.WriteLine(" Soal 5 ");
                Console.WriteLine(" Soal 6 ");
                Console.WriteLine(" Soal 7 ");
                Console.WriteLine(" Soal 8 ");
                Console.WriteLine(" Soal 9 ");
                Console.WriteLine(" Soal 10 ");
                Console.WriteLine();
                Console.WriteLine(" 11. Exit ");


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
                    case 10:
                        Soal10();
                        break;
                    default:
                        Console.WriteLine("Anda memilih yang lain ");
                        break;
                }
            } while (menu != 11);
            

          
        }
        static void Soal1()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("=====Bilangan Prima=====");
                Console.WriteLine();
                Console.Write("Input Batas : ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 2; i < n; i++)
                {
                    if (i == 2)
                    {
                        Console.Write($"{i},");
                    }
                    
                    else if (i %2 != 0)
                    {
                        if (i==3)
                        {
                            Console.Write($"{i},");
                        }   
                        else if (i %3 !=0)
                        Console.Write($"{i},");
                    }

                }
                Console.ReadLine(); 
            } while (ulang);
        }

        
        static void Soal2()
        {
            bool ulang = true;
            do
            {
                Console.Write("Input Batas : ");
                string angkaStr = Console.ReadLine();
                string[] angkaArr = angkaStr.Split(",");
                int[] angkaArrInt = Array.ConvertAll(angkaArr, int.Parse);

                Console.WriteLine(angkaArrInt[1]);
                Console.Write("Input Angka : ");
                



            } while (ulang);
        }
        static void Soal3()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Write("Input : ");
                string input = Console.ReadLine();
                int panjangInput = input.Length;
                int hurufUCount = 0;
                int kapitalCount = 0;
                for (int i = 0; i < panjangInput; i++)
                {
                    if (input[i] == 'u' || input[i]== 'U')
                    {
                        hurufUCount++;
                    }
                    else if (input[i] > 95)
                    {
                        kapitalCount++;
                    }
                }


                /*int hurufUCount = 0;
                int kapitalCount = 0;
                foreach (var items in angkaArr)
                {
                    foreach (var item in items)
                    {
                        byte[] nilai = Encoding.ASCII.GetBytes(items);
                        Console.WriteLine(nilai);
                        *//*if (item == 'u' && item == 'U')
                        {
                            Console.WriteLine(hurufUCoun);
                            hurufUCount++;
                        }*//*

                        

                    }
                }*/
                Console.WriteLine($"Huruf u ada {hurufUCount}");
                Console.WriteLine($"Huruf kapital ada {kapitalCount}");

                Console.ReadLine();


            } while (ulang);
        }
        static void Soal4()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Write("Input : ");
                string input = Console.ReadLine();
               /* int panjangInput = input.Length;*/
                string[] katakata = input.Split(" ");

                for (int i = 0; i < katakata.Length; i++)
                {
                    for (int j = 0; j < katakata[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write($"{katakata[i][j]}");
                        }

                        else if (j == katakata[i].Length - 1)
                        {
                            Console.Write($"{katakata[i][j]} ");
                        }

                        else
                        {
                            Console.Write("*");
                        }


                    }

                }                  
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal5()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Write("Input : ");
                string input = Console.ReadLine();
                /* int panjangInput = input.Length;*/
                string[] katakata = input.Split(" ");

                for (int i = 0; i < katakata.Length; i++)
                {
                    for (int j = 0; j < katakata[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            
                            Console.Write("*");
                        }

                        else if (j == katakata[i].Length - 1)
                        {
                            Console.Write($"* ");
                        }

                        else
                        {
                            Console.Write($"{katakata[i][j]}");
                        }


                    }


                }
                /*foreach (var item in katakata)
                {
                    Console.WriteLine(item);
                }*/
                Console.ReadLine();



            } while (ulang);
        }
        static void Soal6()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Write("Input : ");
                string input = Console.ReadLine();
                /* int panjangInput = input.Length;*/
                string[] katakata = input.Split(" ");

                for (int i = 0; i < katakata.Length; i++)
                {
                    for (int j = 0; j < katakata[i].Length; j++)
                    {
                        if (j >= katakata[i].Length - 3)
                        {
                            Console.Write($"{katakata[i][j]}");
                        }
                        


                       /* else if (j == katakata[i].Length - 1)
                        {

                            Console.Write($" ");
                        }*/
/*                        if (j == 0)
                        {
                            Console.Write($" ");
                        }


                        else
                        {

                            Console.Write($"{katakata[i][j]}");
                        }

*/
                    }
                    Console.Write($" ");

                }
                Console.ReadLine();

            } while (ulang);

        }
        static void Soal7()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Write("Input Batas : ");
                string angkaStr = Console.ReadLine();
                string[] angkaArr = angkaStr.Split(",");
                int[] angkaArrInt = Array.ConvertAll(angkaArr, int.Parse);
                int temp = 0;
                for (int i = 0; i < angkaArrInt.Length; i++)
                {
                    for (int j = 0; j < angkaArrInt.Length; j++)
                    {
                        if (angkaArrInt[j] > angkaArrInt[j + 1])
                        {
                            temp = angkaArrInt[j];
                            angkaArrInt[j] = angkaArrInt[j + 1];
                            angkaArrInt[j + 1] = temp;
                        }
                        else if (j== angkaArrInt.Length - 1)
                        {
                            break;
                        }
                    }
                    if (angkaArrInt[i] > angkaArrInt[i+1])
                    {
                        temp = angkaArrInt[i];
                        angkaArrInt[i]=angkaArrInt[i+1];
                        angkaArrInt[i + 1] = temp;
                    }
                    
                    

                }

                foreach (var item in angkaArrInt)
                {
                    Console.WriteLine(item);
                }


                Console.ReadKey();
            } while (ulang);
        }
        static void Soal8()
        {
            bool ulang = true;
            do
            {
                Console.Write("Input Angka : ");
                string angkaStr = Console.ReadLine();



            } while (ulang);
        }
        static void Soal9()
        {
            bool ulang = true;
            do
            {
                Console.Write("Input Angka : ");
                string angkaStr = Console.ReadLine();



            } while (ulang);
        }
        static void Soal10()
        {
            bool ulang = true;
            do
            {
                Console.Write("Input Angka : ");
                string angkaStr = Console.ReadLine();



            } while (ulang);
        }
    }
}

using System;

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

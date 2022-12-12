using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
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
                Console.WriteLine("Time Conversion");
                Console.WriteLine("================");
                //Input
                Console.WriteLine("Ubah dan cetak waktu menjadi format 24 jam:");
                Console.WriteLine("Sampel Imput: ");
                string jam = Console.ReadLine();
                string[] jamArr = jam.Split(":");


                if (jamArr[2].Contains("PM"))
                {
                    jamArr[0] = (int.Parse(jamArr[0]) + 12).ToString();

                    /*  Console.WriteLine(jamArr[0]);*/

                    jamArr[2] = jamArr[2].Substring(0, 2);

                    /*Console.WriteLine(jamArr[2]);*/



                }
                string cetak = string.Join(":", jamArr);
                Console.WriteLine();
                Console.WriteLine(cetak);


                Console.ReadLine();
            } while (ulang);
        }


        static void Soal2()
        {
            bool ulang = true;
            do
            {
                Console.Write("Total Menu : ");
                int totalMenu = int.Parse(Console.ReadLine());

                Console.Write("Index Makanan Alergi : ");
                int indexMakananAlergi = int.Parse(Console.ReadLine());


                Console.Write("Harga Menu : ");
                string hrgMenu = Console.ReadLine();
                string[] hrgMenuArrStr = hrgMenu.Split(",");
                int[] hrgMenuArrInt = Array.ConvertAll(hrgMenuArrStr, int.Parse);
                List<int> hrgMenuList = hrgMenuArrInt.ToList();
                List<int> hrgMenuList2 = Array.ConvertAll(hrgMenu.Split(","), int.Parse).ToList();
                int sum = 0;
                string menuDimakan = string.Join(" + ", hrgMenuList);
                int length = hrgMenuList.Count;
                for (int i = 0; i < length; i++)
                {

                    sum = sum + hrgMenuList[i];
                }



                Console.Write("Uang Elsa = ");
                int uang = int.Parse(Console.ReadLine());
                int sisaUang = uang - ((sum - hrgMenuList[indexMakananAlergi]) / 2);

                int bayar = (sum - hrgMenuList[indexMakananAlergi]) / 2;

                Console.WriteLine($"Total Makanan yang dimakan elsa dan dimas  {menuDimakan} = {sum}");
                Console.WriteLine($"Makanan yang elsa bisa makan = {sum - hrgMenuList[indexMakananAlergi]} Karena {sum} - {hrgMenuList[indexMakananAlergi]}");
                //Input
                /*string angkaStr = Console.ReadLine();
                string[] angkaArr = angkaStr.Split(",");
                int[] angkaArrInt = Array.ConvertAll(angkaArr, int.Parse);

                Console.WriteLine(angkaArrInt[1]);
                Console.Write("Input Angka : ");
*/
                Console.WriteLine();
                //Outpur
                if (sisaUang > 0)
                {
                    Console.WriteLine($"Elsa harus membayar = {bayar}");
                    Console.WriteLine($"Sisa Uang Elsa = {uang - sisaUang}");
                }
                else if (sisaUang < 0)
                {
                    Console.WriteLine($"Elsa harus membayar = {bayar}");
                    Console.WriteLine($"Uang Elsa kurang = {uang - bayar}");
                }
                else if (sisaUang == 0)
                {
                    Console.WriteLine("Uang Elsa Pas");
                }
                else
                {
                    Console.WriteLine("Something Wrong");
                }






                Console.ReadKey();


            } while (ulang);
        }
        static void Soal3()
        {
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.WriteLine("Input :");
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');
                // int[] inputInt = ConvertAll(inputArr, int.Parse)?
                int[] inputArrInt = Array.ConvertAll(inputArr, int.Parse);

                List<int> inputList = inputArrInt.ToList();

                int length = inputList.Count;
                int temp = 0;
                int countMax = 0;

                for (int j = 0; j < length; j++)
                {
                    for (int i = 0; i < length - 1; i++)
                    {
                        if (inputList[i] < inputList[i + 1])
                        {
                            temp = inputList[i];
                            inputList[i] = inputList[i + 1];
                            inputList[i + 1] = temp;
                        }
                    }


                }
                for (int i = 0; i < length - 1; i++)
                {
                    if (inputList[0].ToString() == inputList[i].ToString())
                    {
                        countMax++;
                    }
                }



                Console.WriteLine("Output Sampel :");
                Console.WriteLine(countMax);

                Console.ReadLine();


            } while (ulang);
        }
        static void Soal4()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Sample Input : ");
                Console.Write("arr : ");
                string input = Console.ReadLine();
                string[] arr = input.Split(',');
                int[] arrInt = Array.ConvertAll(arr, int.Parse);
                List<int> arrList = arrInt.ToList();
                List<int> tempList = new List<int>();
                int length = arrList.Count();

                Console.Write("Rot : ");
                int rot = int.Parse(Console.ReadLine());

                Console.WriteLine("Sebelum di ubah");
                foreach (var item in arrList)
                {
                    Console.Write(item + " ");
                }
                /*
                                foreach (var item in tempList)
                                {
                                    Console.WriteLine(item+" ");
                                }*/
                for (int i = 0; i < length; i++)
                {
                    tempList.Add(arrList[0]);
                    arrList.Remove(arrList[0]);
                }

                Console.WriteLine("sesudah diubah");

                Console.WriteLine();
                foreach (var item in arrList)
                {
                    Console.Write(item + " ");
                }

                /*foreach (var item in tempList)
                {
                    Console.WriteLine(item + " ");
                }*/
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal5()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                                Console.ReadLine();



            } while (ulang);
        }
        static void Soal6()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                
                Console.ReadLine();

            } while (ulang);

        }
        static void Soal7()
        {
            bool ulang = true;
            do
            {
                Console.Clear();
                
                Console.ReadKey();
            } while (ulang);
        }
        static void Soal8()
        {
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.ReadLine();


            } while (ulang);
        }
        static void Soal9()
        {
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.ReadLine();
            } while (ulang);
        }
        static void Soal10()
        {
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.ReadLine();
            } while (ulang);
        }
        /*static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                belajarList();
            } while (true);
        }

        static void belajarList()
        {
             
            List<int> listInt = new List<int>();
            List<string> listStr = new List<string>();
            Console.Write("Ïnput : ");
            listInt = 
           

            for (int i = 10; i > 0; i--)
            {
                listInt.Add(i);
                listStr.Add("String ke-" + i);
            }
            int len = listInt.Count;
            int lenStr = listStr.Count;

            
        }*/
    }
}


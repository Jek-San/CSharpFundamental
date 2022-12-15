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
                        Soal2Fix();
                        break;
                    case 3:
                        Soal3Tutor();
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
                if (rot>26)
                {
                    rot = rot % 26;
                }

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
                        }
                        else
                        {
                            pengubah = inputChr[i] + rot;
                        }
                        something = (char)pengubah;
                        inputChr[i] = something;
                    }
                    else if (inputChr[i] >= 65 && inputChr[i] <= 90)
                    {
                        if (inputChr[i] + rot >= 90)
                        {
                            pengubah = inputChr[i] + rot - 26;
                        }
                        else
                        {
                            pengubah = inputChr[i] + rot;
                        }
                        something = (char)pengubah;
                        inputChr[i] = something;
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
                string panjang = "1 3 1 4 6 2 1 1 3 5 2 3 1 1 1 1 5 2 3 1 3 5 4 3 2 5";
                string[] panjangArr = panjang.Split(' ');
                int[] panjangArrInt = Array.ConvertAll(panjangArr, int.Parse);

                string alfabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
                string[] alfabetArr = alfabet.Split(' ');

                Console.Write("Input Text : ");
                string input = Console.ReadLine();
                int nilai = 1;


                int length = input.Length;

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < alfabetArr.Length; j++)
                    {
                        if (input[i] == char.Parse(alfabetArr[j]))
                        {

                            nilai = nilai * panjangArrInt[j];

                        }

                    }

                }
                Console.WriteLine($"Output = {nilai}");

                Console.ReadLine();
            } while (ulang);
        }

        static void Soal2Fix()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                string panjang = "1 3 1 4 6 2 1 1 3 5 2 3 1 1 1 1 5 2 3 1 3 5 4 3 2 5";
                string[] panjangArr = panjang.Split(' ');
                int[] panjangArrInt = Array.ConvertAll(panjangArr, int.Parse);

                string alfabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
                string[] alfabetArr = alfabet.Split(' ');

                Console.Write("Input Text : ");
                string input = Console.ReadLine();
                int nilai = 1;
                int[] simpanP = new int[input.Length];


                int length = input.Length;

                for (int i = 0; i < length; i++)
                {
                    char something = input[i];
                    int index = Array.IndexOf(alfabetArr, something);

                    int penyimpan = panjangArrInt[index];
                    simpanP[i] = penyimpan;

                }
                Array.Sort(simpanP);
                Array.Reverse(simpanP);


                Console.WriteLine($"Output = {simpanP[0] * input.Length}");

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
                Console.WriteLine("Input : ");
                string input = Console.ReadLine().ToLower();
                char[] inputChar = input.ToCharArray();
                //string[] inputArr = input.Split(' ');
                string vokal = "aeiuo";
                char[] vokalChar = vokal.ToCharArray();
                string konsonan = "bcdfghjklmnpqrstvwxyz";
                char[] konsonanChar = konsonan.ToCharArray();
                Array.Sort(inputChar);
                List<char> listVokal = new List<char>();
                List<char> listKonsonan = new List<char>();

                //looping untuk cari cononan
                for (int i = 0; i < vokalChar.Length; i++)
                {
                    for (int j = 0; j < inputChar.Length; j++)
                    {

                        if (vokalChar[i] == inputChar[j])
                        {
                            listVokal.Add(vokal[i]);

                        }


                    }

                }
                for (int i = 0; i < konsonanChar.Length; i++)
                {
                    for (int j = 0; j < inputChar.Length; j++)
                    {

                        if (konsonanChar[i] == inputChar[j])
                        {
                            listKonsonan.Add(konsonanChar[i]);

                        }

                    }

                }


                Console.Write("Vokal = ");
                foreach (var item in listVokal)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
                Console.Write("Konsonan =");
                foreach (var item in listKonsonan)
                {
                    Console.Write(item);
                }
                Console.ReadLine();
            } while (ulang);
        }

        static void Soal3Tutor()
            {
                Console.Clear();
                Console.WriteLine("Input : ");
                string input = Console.ReadLine().ToLower();
                char[] inputChar = input.ToCharArray();
                //string[] inputArr = input.Split(' ');
                string vokal = "aeiuo";
                char[] vokalChar = vokal.ToCharArray();
                string konsonan = "bcdfghjklmnpqrstvwxyz";
                char[] konsonanChar = konsonan.ToCharArray();
                Array.Sort(inputChar);
                List<char> listVokal = new List<char>();
                List<char> listKonsonan = new List<char>();

                //looping untuk cari cononan
                for (int i = 0; i < inputChar.Length; i++)
                {
                    int index = Array.IndexOf(vokalChar, inputChar[i]);
                    if (index != -1)
                    {
                        listVokal.Add(inputChar[i]);
                    }
                    else
                    {
                        listKonsonan.Add(inputChar[i]);
                    }
                }


                Console.Write("Vokal = ");
                foreach (var item in listVokal)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
                Console.Write("Konsonan =");
                foreach (var item in listKonsonan)
                {
                    Console.Write(item);
                }
                Console.ReadLine();
        }
        static void Soal4()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("Password : ");
                string pass = Console.ReadLine();
                char[] passChar = pass.ToCharArray();
                bool panjangPass = false;
                bool passSimbol = false;
                bool angkaStatus = false;
                bool hurufBesarStatus = false;
                bool hurufKecilStatus = false;


                string angka = "1 2 3 4 5 6 7 8 9 0";
                char[] angkaChar = Array.ConvertAll(angka.Split(" "), char.Parse);
                char[] hurufBesarArr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

                char[] hurufKecil = "abcdefghijklmnopqrstuvwxyz".ToLower().ToCharArray();

                string simbol = "!@#$%^&*";
                char[] simbolChar = simbol.ToCharArray();

                int idxhurufKecil = pass.IndexOfAny(hurufKecil);
                int idxAngka = pass.IndexOfAny(angkaChar);
                int idxHurufBesar = pass.IndexOfAny(hurufBesarArr);
                int idxSymbol = pass.IndexOfAny(simbolChar);



                if (pass.Length <= 6)
                {

                    Console.WriteLine("Password Weak & Kurang dari 6 digit");
                }
                if (idxSymbol < 0)
                {
                    Console.WriteLine("Password Weak & Kurang Symbol");
                }
                if (idxAngka < 0)
                {
                    Console.WriteLine("Password Weak & Kurang angka");
                }
                if (idxHurufBesar < 0)
                {
                    Console.WriteLine("Password Weak & Kurang Besar");
                }


                /*for (int i = 0; i < passChar.Length; i++)
                {
                    int index = Array.IndexOf(simbolChar, passChar[i]);
                    if (index != 1)
                    {
                        passSimbol = true;
                    }

                    int indexAngka = Array.IndexOf(angkaArr, passChar[i]);
                    if (indexAngka != 1)
                    {
                        angkaStatus = true;
                    }
                    int indexHurufBsr = Array.IndexOf(hurufBesarArr, passChar[i]);
                    if (indexHurufBsr != 1)
                    {
                        hurufBesarStatus = true;
                    }
                    index = Array.IndexOf(hurufKecil, passChar[i]);
                    if(index != 1)
                    {
                        hurufKecilStatus = true;
                    }
                    
                }
*/





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








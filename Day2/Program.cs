﻿using System;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Masukkan nilai r : ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"Luas lingkaran = {luasLingkaran(r)} dan Keliling lengkaran = {kelilingLingkaran(r)}");
            Console.WriteLine("==============================");

            Console.Write("Masukkan Angka : ");
            int angka = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Pembagi : ");
            int pembagi = int.Parse(Console.ReadLine());

            if (findModulus(angka, pembagi) == 0)
            {
                Console.WriteLine($"{angka} % {pembagi} adalah 0");
            }
            else
            { 
                Console.WriteLine($"{angka} % {pembagi} bukan 0 melainkan {findModulus(angka, pembagi)}");

            }
            




        }

        public static int counterRokok(int rokok)
        {
            
            return rokok / 8;
        }

        public static double kelilingLingkaran(int r)
        {
            const double pi = 22.0/7.0;
            
            return 2 * pi * r;
        }

        public static double luasLingkaran(int r)
        {
            const double pi = 22.0 / 7.0;
            return pi * r * r;
        }

        public static void Inputan()
        {
            string[] smartphone = { "Iphone", "Samsung", "Nokia" };

        }

        public static int findModulus(int angka, int pembagi) {

            return (angka % pembagi) ;
        }
    }
}
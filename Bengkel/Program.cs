using System;
using System.Collections.Generic;
using System.Linq;

namespace Bengkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulang = true;
            do
            {

                Console.WriteLine("Sample Input : ");
                Console.Write("arr : ");
                string input = Console.ReadLine();
                string[] arr = input.Split(',');
                int[] arrInt = Array.ConvertAll(arr, int.Parse);
                List<int> arrList = arrInt.ToList();
                List<int> tempList= new List<int>();
                int length = arrList.Count();

                Console.Write("Rot : ");
                int rot = int.Parse(Console.ReadLine());

                Console.WriteLine("Sebelum di ubah");
                foreach (var item in arrList)
                {
                    Console.Write(item+" ");
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


            } while (ulang);
        }
    }
}

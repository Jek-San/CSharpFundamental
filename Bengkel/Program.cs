using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;


namespace Bengkel
{

    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Input :");
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(',');
            List<int> inputInt = Array.ConvertAll(inputSplit, int.Parse).ToList();
            List<int> totalKecil = new List<int>();
            List<int> totalBesar = new List<int>();
            int length = inputInt.Count;

            inputInt.Sort();
            Console.Write("Angka Urut :");
            foreach (var item in inputInt)
            {
                Console.WriteLine($"{item} ");
            }
            
           
            for (int i = 0; i < 3; i++) {
                int temp = inputInt[i];
                totalKecil.Add(temp);
            }
            inputInt.Reverse();
            for (int i = 0; i < 3; i++)
            {
                int temp = inputInt[i];
                totalBesar.Add(temp);
            }

            Console.Write("Outout : ");
            Console.WriteLine($"total 3 Angka terbesar : {totalBesar.Sum()}");
            Console.WriteLine($"         total 3 Angka terkecil : {totalKecil.Sum()}");


            /*Console.Write("Angka Urut :");
            
            string urut = Console.ReadLine();
            string[] urutSplit = urut.Split(' ');
            int[] urutInt = Array.ConvertAll(urutSplit, int.Parse);
*/

            
            
        }
    }
}

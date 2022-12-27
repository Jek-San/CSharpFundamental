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
            int i = 1213;

            string cetak = i.ToString("00000000");

            Console.WriteLine(cetak);


            /*Console.Write("Angka Urut :");
            
            string urut = Console.ReadLine();
            string[] urutSplit = urut.Split(' ');
            int[] urutInt = Array.ConvertAll(urutSplit, int.Parse);
*/

            
            
        }
    }
}

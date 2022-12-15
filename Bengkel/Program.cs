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
           
            
            bool ulang = true;
            do
            {
                Console.Clear();
                //sebuah angka yang habis dibagi dengan k
                Console.WriteLine("beautifulDays");
                Console.WriteLine("=============\n");
                Console.Write("I = ");
                int i = int.Parse(Console.ReadLine());  
                Console.Write("J = ");
                int j = int.Parse(Console.ReadLine());
                Console.Write("K = ");
                int k = int.Parse(Console.ReadLine());
                List<int> hari = new List<int>();
                List<int> pembalik = new List<int>();
                List<double> hariCantik = new List<double>();
                char[] penampung;
                double penampungDouble;

                for (int b = i; b <= j ; b++)
                {
                    hari.Add(b);
                    penampung = b.ToString().ToCharArray();
                    penampung = penampung.Reverse().ToArray();
                    Console.WriteLine(penampung);
                    pembalik.Add(int.Parse(penampung));
                }

                List<double> hariIndah = new List<double>();
                for (int c = 0; c < hari.Count; c++)
                {
                    penampungDouble = ((hari[c] - pembalik[c]) / k);
                    if ((hari[c] - pembalik[c])%k == 0)
                    {
                        hariCantik.Add(hari[c]);
                    }

                    
                }

                string cetak = string.Join(",", hariCantik);
                Console.WriteLine($"Hari Cantik itu pada tanggal : {cetak}");



                
                  



/*                Console.WriteLine("ini Hari");
                foreach (var item in hari)
                {
                    Console.Write(item);
                }

                Console.WriteLine();

                    Console.WriteLine("Ïni pembalik");
                foreach (var item in pembalik)
                {
                    Console.Write(item);
                }


                Console.WriteLine();


                
*/                


                Console.ReadLine();

            } while (ulang);
        }
    }
}

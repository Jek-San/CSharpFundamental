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
                //Outpur
                if (sisaUang >0)
                {
                    Console.WriteLine($"Elsa harus membayar = {bayar}");
                    Console.WriteLine($"Sisa Uang Elsa = {uang - sisaUang}");
                }
                else if(sisaUang<0)
                {
                    Console.WriteLine($"Elsa harus membayar = {bayar}");
                    Console.WriteLine($"Uang Elsa kurang = {uang - bayar}");
                }
                else if (sisaUang==0)
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
    }
}

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
                string panjang = "1 3 1 4 6 2 1 1 3 5 2 3 1 1 1 1 5 2 3 1 3 5 4 3 2 5";
                string[] panjangArr = panjang.Split(' ');
                int[] panjangArrInt = Array.ConvertAll(panjangArr, int.Parse);

                string alfabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
                string[] alfabetArr = alfabet.Split(' ');

                Console.WriteLine("Input Text : ");
                string input = Console.ReadLine();


                int temp;
                int length = input.Length;

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < alfabetArr.Length ; j++)
                    {
                        if (input[i] == char.Parse(alfabetArr[j]))
                        {
                            Console.WriteLine("*************");
                            Console.WriteLine(panjangArrInt[j]);
                        }
                        Console.WriteLine("+++++++++++++++++");
                    }
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");

                }
                Console.ReadLine();
            } while (ulang);
        }
    }
}

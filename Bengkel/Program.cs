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
                Console.Write("Input = ");
                string input = Console.ReadLine().ToUpper();
                char[] inputChar = input.ToCharArray();
                int simbol = 0;
                int p = 0;
                int lembah = 0; 

                for (int i = 0; i < inputChar.Length; i++)
                {
                    if (p == 0 && simbol == -1)
                    {
                        lembah++;   
                    }
                    else if (inputChar[i] == 'U')
                    {
                        simbol++;
                    }
                    else if (inputChar[i]=='D')
                    {
                        simbol--;
                    }
                }

                Console.WriteLine($"Output = {lembah}");
                Console.WriteLine($"simbol = {simbol}");


            } while (ulang);
        }
    }
}

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
                    for (int i = 0; i < length-1; i++)
                    {
                        if (inputList[i] < inputList[i+1])
                        {
                            temp= inputList[i];
                            inputList[i] = inputList[i + 1];
                            inputList[i+1] = temp;
                        }
                    }
                   
                    
                }
                for (int i = 0; i < length-1; i++)
                {
                    if (inputList[0].ToString() == inputList[i].ToString())
                    {
                        countMax++;
                    }
                }

               

                Console.WriteLine("Output Sampel :" );
                Console.WriteLine(countMax);


                

            } while (ulang);
        }
    }
}

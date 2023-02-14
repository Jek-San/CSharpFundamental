using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.hackerrank.com/challenges/kangaroo/
            int x1 = 1571, v1 = 4240, x2 = 9023, v2 = 4234;
            string result = "NO";
            if ((v1 > v2 && x1 > x2) || (v2 > v1 && x2 > x1))
            {

                Console.WriteLine(result);
            }
            else
            {
                int position1 = x1;
                int position2 = x2;
                int batas = 0;
                while (position1 == position2 || position1 >= 10000 || position2 >= 10000 && batas ==4)
                {
                    batas++;
                    position1 += v1;
                    position2 += v2;
                    if (position1 == position2)
                    {
                        result = "YES";
                    }

                }

            }
            Console.WriteLine(result);
        }


    


    static void ProbleSolving_AppleAndOrange()
        {
            //https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
            int s = 7, t = 10, a = 4, b = 12;
            List<int> apples = new List<int> { 2, 3, -4 };
            List<int> oranges = new List<int> { 3, -2, 4 };

            var countApple = apples.Count(x => x + a >= s && x + a <= t);
            var countOrange = oranges.Count(x => x + b >= s && x + b <= t);
            Console.WriteLine(countApple);
            Console.WriteLine(countOrange);

        }
        static void ProblemSolving_TimeConversion()
        {
            //https://www.hackerrank.com/challenges/time-conversion/
            string s = "12:45:54PM";

            string result = "";
            bool cekAM = s.Contains("AM");
            bool cekPM = s.Contains("PM");


            string[] sSplit = s.Split(':');

            if (cekPM)
            {
                if (int.Parse(sSplit[0]) < 12)
                {
                    sSplit[0] = (int.Parse(sSplit[0]) + 12).ToString();

                }

            }

            if (cekAM)
            {
                if (sSplit[0] == "12")
                {
                    sSplit[0] = "00";
                    sSplit[2] = sSplit[2].Substring(0, 2);


                }

            }

            sSplit[2] = sSplit[2].Substring(0, 2);

            result = string.Join(":", sSplit);





            Console.WriteLine(result);

        }
        static void ProbleSolvingTallesCandles()
        {
        //https://www.hackerrank.com/challenges/time-conversion
            List<int> candles = new List<int> { 4, 4, 1, 3 };
            int tallest = candles.Max();
            int count = candles.Count(x => x == tallest);
            Console.WriteLine(count);
        }
        static void ProblemSolving_MiniMaxSum()
        {
            //https://www.hackerrank.com/challenges/mini-max-sum/
            List<int> arr = new List<int> { 5, 5, 5, 5, 5 };
            int len = arr.Count;
            List<long> result = new List<long>();

            for (int i = 0; i < len; i++)
            {
                long sum = 0;
                for (int j = 0; j < len; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        sum += arr[j];
                    }
                }

                result.Add(sum);
            }
            Console.WriteLine($"{result.Min()} {result.Max()}");
        }
    }
}

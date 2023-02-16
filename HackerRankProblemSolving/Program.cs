using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp = "";
            string value1 = "value 1";
            string value2 = "value 2";
            Console.WriteLine("Before tukar");
            Console.WriteLine($"valu1 = {value1}");
            Console.WriteLine($"value 2 = {value2}");

            temp = value1;
            value1= value2;
            value2 = temp;
            Console.WriteLine("After tukar");
            Console.WriteLine($"valu1 = {value1}");
            Console.WriteLine($"value 2 = {value2}");

        }

        static void ReverseString()
        {
            string input = "Halo Guus";
            var oke = input.ToCharArray();
            var reverse = oke.Reverse().ToArray();
            var result = new string(reverse);
            Console.WriteLine(result);

            string resultBaru = "";
            var inputArray = input.ToCharArray();
            int len = inputArray.Length;
            for (int i = len - 1; i >= 0; i--)
            {
                resultBaru += inputArray[i];
            }
            Console.WriteLine(resultBaru);
        }
        static void TestInput()
        {
            Console.WriteLine("Masukkan No Loker yang ingin anda pilih : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Lantai ke {Test(input)}");
        }
        static int Test(int loker)
        {
            int lokerKe = 0;
            int batas = 5;
            int lantai; 
            int pola = 0;

            for (lantai = 1; lantai < int.MaxValue; lantai++)
            {
                for (int i = 0; i < batas + pola; i++)
                {
                    lokerKe++;
                    if (lokerKe == loker)
                    {
                        return lantai;
                    }
                }
                pola++;
                if (pola > 3)
                {
                    pola = 1;
                }
            }
            return lantai;
            
        }
        static void ProblemSplving_MinMaxScoreBasketBall()
        {
            //https://www.hackerrank.com/challenges/breaking-best-and-worst-records/
            List<int> scores = new List<int> { 0, 9, 3, 10, 2, 20 };
            List<int> result = new List<int>();
            int minChange = 0;
            int maxChange = 0;
            int len = scores.Count;
            int min = 0;
            int max = 0;
            int now = 0;
            max = scores[0];
            min = scores[0];
            for (int i = 0; i < len; i++)
            {


                if (scores[i] > max)
                {
                    max = scores[i];
                    maxChange++;
                }
                else
                {
                    if (scores[i] < min)
                    {
                        min = scores[i];
                        minChange++;


                    }
                }

            }
            result.Add(maxChange); result.Add(minChange);
            Console.WriteLine($"{maxChange}, {minChange}");
        }
        static void ProblemSolving_Grades()
        {
            //https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true
            List<int> grades = new List<int> { 73, 67, 38, 33 };
            List<int> result = new List<int>();
            int len = grades.Count;
            for (int i = 0; i < len; i++)
            {
                int nilai = grades[i];
                int cekTambah = 0;

                if (nilai % 5 == 0)
                {
                    result.Add(nilai);
                }
                else
                {
                    while (nilai % 5 != 0)
                    {
                        cekTambah++;
                        nilai += 1;
                    }
                    if (cekTambah <= 2)
                    {
                        if (nilai >= 40)
                        {
                            result.Add(nilai);

                        }
                        else
                        {
                            result.Add(grades[i]);
                        }
                    }
                    else
                    {
                        result.Add(grades[i]);
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void ProblemSolving_KangorooJump()
        {
            int x1 = 4523, v1 = 8092, x2 = 9419, v2 = 8076;
            string result = "NO";
            if (v1 > v2 && x1 > x2 || v2 > v1 && x2 > x1)
            {
                Console.WriteLine(result);
            }
            else
            {
                int position1 = x1;
                int position2 = x2;
                while (position1 != position2)
                {
                    position1 += v1;
                    position2 += v2;
                    Console.WriteLine(position1 + " " + position2);
                    if (position1 == position2)
                    {
                        result = "YES";
                        break;
                    }

                    if (position1 >= int.MaxValue || position2 >= int.MaxValue)
                    {
                        break;
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

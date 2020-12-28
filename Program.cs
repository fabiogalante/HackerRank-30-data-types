using System;
using System.Globalization;
using System.Linq;

namespace _30_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        private static void MiniMaxSum()
        {



            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Sort(arr);

            long start = 0;


            for (int i = 0; i < arr.Length - 1; i++)
            {
                start += arr[i];
            }

            long finish = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                finish += arr[i];
            }

            Console.WriteLine($"{start} {finish}");

           

        }

        private static void day3()
        {

            int N = Convert.ToInt32(Console.ReadLine());

            var mode = N % 2;

            //switch (mode)
            //{
            //    case 1:
            //        Console.WriteLine("Weird");
            //        return;
            //    case 0 when N > 20:
            //        Console.WriteLine("Not Weird");
            //        return;
            //    case 0 when N >= 6:
            //        Console.WriteLine("Weird");
            //        return;
            //    case 0 when N >= 2:
            //        Console.WriteLine("Not Weird");
            //        break;
            //}



            if (mode == 1)
            {
                Console.WriteLine("Weird");
                return;
            }

            if (mode == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
                return;
            }

            if (mode == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
                return;
            }

            if (mode == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }


        }

        private static void day2()
        {
            //https://www.hackerrank.com/challenges/30-operators/problem
            
            double meal_cost = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }

        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tax = (meal_cost * tax_percent) / 100;
            double tip = (meal_cost * tip_percent / 100);
            double totalCost = meal_cost + tax + tip;
            Console.WriteLine(Math.Round(totalCost));
        }

        private void day1()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            int sum_i = Convert.ToInt32(Console.ReadLine());
            double sum_d = Convert.ToDouble(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            string concat_s = Console.ReadLine();

            Console.WriteLine(sum_i + i);

            Console.WriteLine(Convert.ToDouble(sum_d + d, System.Globalization.CultureInfo.InvariantCulture).ToString("N1"));

            Console.WriteLine($"{s} {concat_s}");
        }
    }
}

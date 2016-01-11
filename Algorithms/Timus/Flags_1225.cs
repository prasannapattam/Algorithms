using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1225
    //Fibonacci series
    //Place flags next to each other
    public static class Flags_1225
    {
        private static long[] fibNumbers;

        public static void Test()
        {
            DateTime dtStart = DateTime.Now;

            int number = 100;

            fibNumbers = new long[number + 1];

            for(int counter = 1; counter <= number; counter ++)
                GetWays(counter);

            DateTime dtEnd = DateTime.Now;

            TimeSpan ts = dtEnd - dtStart;

            Console.WriteLine("Time taken: " + ts.TotalSeconds);
        }

        public static long GetWays(int stripe)
        {
            long result = 2;

            if (stripe != 1 && stripe != 2)
            {
                result = GetFibonacciSum(stripe);

                //multiplying by 2 to get the actual value
                result *= 2;
            }

            Console.WriteLine("Stripe: {0}, Ways: {1}", stripe, result);

            return result;
        }

        public static long GetFibonacciSum(int number)
        {
            if (fibNumbers[number] != 0)
                return fibNumbers[number];

            long nextNumber = 0;
            if(number <= 1)
            {
                nextNumber = number < 0 ? 0 : number;
            }
            else
            {
                nextNumber = GetFibonacciSum(number - 1) + GetFibonacciSum(number - 2);
            }

            fibNumbers[number] = nextNumber;
            return nextNumber;
        }
    }
}

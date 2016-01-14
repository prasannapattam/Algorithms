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
        public static void Test()
        {
            DateTime dtStart = DateTime.Now;

            int number = 10;

            Console.WriteLine("printing the Fibonacci numbers");

            for (int counter = 0; counter <= number; counter ++)
                GetWays(counter);

            DateTime dtEnd = DateTime.Now;

            TimeSpan ts = dtEnd - dtStart;

            Console.WriteLine("Time taken: " + ts.TotalSeconds);
        }

        public static long GetWays(int stripe)
        {
            long result = 2;

            //printing the Fibonacci numbers
            result = GetFibonacciNumber(stripe);
            Console.WriteLine(result);


            if (stripe != 1 && stripe != 2)
            {
                result = GetFibonacciNumber(stripe);
                //multiplying by 2 to get the actual value
                result *= 2;
            }

            //Console.WriteLine("Stripe: {0}, Ways: {1}", stripe, result);

            return result;
        }

        public static long GetFibonacciNumber(int number)
        {
            if (number == 0 || number == 1)
                return number;

            long a = 0, b = 1, c = a + b;
            for(int counter = 2; counter <= number; counter++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}

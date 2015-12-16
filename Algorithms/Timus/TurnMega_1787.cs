using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1787
    public static class TurnMega_1787
    {
        private static int TurnMega(int k, int n, int[] a)
        {
            int current = 0;

            for (var time = 0; time < a.Length; time++)
            {
                if (a[time] > k)
                    current += a[time] - k;
                else
                {
                    current -= k - a[time];
                    current = current < 0 ? 0 : current;
                }
            }

            return current;
        }

        public static void Test()
        {
            //Console.WriteLine(TurnMega(5, 3, new int[] { 6, 7, 2 }));
            Console.WriteLine(TurnMega(5, 3, new int[] { 6, 2, 7 }));
            //Console.WriteLine(TurnMega(4, 4, new int[] { 1, 5, 1, 5 }));
        }
    }
}

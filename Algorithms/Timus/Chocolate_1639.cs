using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1639
    //Find the first or second in a round robin of two people
    public static class Chocolate_1639
    {
        public static void Test()
        {
            var result1 = GetStart(2, 4);
            var result2 = GetStart(1, 3);
        }

        public static string GetStart(int m, int n)
        {
            string result;

            int totalCuts = (m * n) - 1;

            if (totalCuts % 2 == 1)
                result = "[:=[first]";
            else
                result = "[second]=:]";

            Console.WriteLine(m.ToString() + ", " + n.ToString() + ": " + result);

            return result;
        }
    }
}

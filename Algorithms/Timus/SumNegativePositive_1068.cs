using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1068
    //Sum of numbers from 1 to N inclusive. N can be negative
    public static class SumNegativePositive_1068
    {
        public static void Test()
        {
            GetSum(-3);
            GetSum(1);
            GetSum(0);
            GetSum(-1);
            GetSum(-5);
        }

        public static int GetSum(int number)
        {
            int absNumber = Math.Abs(number);
            int sum = (absNumber * (absNumber + 1)) / 2;

            if (number <= 0)
                sum = 1 - sum;

            Console.WriteLine(number + " : " + sum);

            return sum;
        }
    }
}

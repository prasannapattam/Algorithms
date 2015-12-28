using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/forum/?space=1&num=1924
    //Finding even or odd in a sequence of consequtive numbers starting from 1
    public static class FourImps_1924
    {
        public static void Test()
        {
            FourImps(1);
            FourImps(4);
        }

        public static string FourImps(int n)
        {
            string result;
            int oddCount = 0;

            //find the odd one out
            if (n % 2 == 0)
                oddCount = n / 2;
            else
                oddCount = (n / 2) + 1;

            if (oddCount % 2 == 0)
                result = "black";
            else
                result = "grimy";

            Console.WriteLine(result);

            return result;
        }
    }
}

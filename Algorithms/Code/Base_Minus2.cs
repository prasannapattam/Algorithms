using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Code
{
    //Get the numerical representation of any base
    public class Base_Minus2
    {
        public static void Test()
        {

            int input = -30;

            int[] arr = GetArr(input, -2);

            var number = GetNumber(arr);

        }

        private static double GetNumber(int[] arr)
        {
            double num = 0;
            for (int counter = 0; counter < arr.Length; counter++)
            {
                var newNum = arr[counter] * Math.Pow(-2, counter);
                num += newNum;
            }

            return num;
        }

        private static int[] GetArr(int number, int bas)
        {
            string num = "";
            List<int> lst = new List<int>();

            while (number != 0)
            {
                int reminder = Math.Abs(number % bas);
                lst.Add(reminder);
                num += reminder.ToString();

                number = (number - reminder) / bas;
            }

            return lst.ToArray();
        }
    }
}

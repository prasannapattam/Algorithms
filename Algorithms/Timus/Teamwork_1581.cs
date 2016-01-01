using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1581
    //Sequence numbers in writing
    //Input: 1 1 2 3 3 3 10 10
    //Output: 2 1 1 2 3 3 2 10
    public static class Teamwork_1581
    {
        public static void Test()
        {
            GetNumbers(new int[] { 1, 1, 2, 3, 3, 3, 10, 10, 11 });
        }

        public static int[] GetNumbers(int[] input)
        {
            List<int> lst = new List<int>();

            int prevNumber = 0;
            int numCount = 0;
            for(int counter = 0; counter < input.Length; counter++)
            {
                if(counter == 0)
                {
                    prevNumber = input[counter];
                }

                if(input[counter] == prevNumber)
                {
                    numCount++;
                }
                else
                {
                    lst.Add(numCount);
                    lst.Add(prevNumber);
                    numCount = 1;
                    prevNumber = input[counter];
                }
            }

            if(input.Length > 0)
            {
                lst.Add(numCount);
                lst.Add(prevNumber);
            }

            int[] result = lst.ToArray();

            Console.WriteLine("Input: " + String.Join(",", input));
            Console.WriteLine("Output: " + String.Join(",", result));

            return result;
        }
    }
}

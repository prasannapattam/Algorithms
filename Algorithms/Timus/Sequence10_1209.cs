using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1209
    //Digit in a sequence of 10 power
    public static class Sequence10_1209
    {
        public static void Test()
        {
            GetPositionValues(new int[] { 1, 3, 1, 14, 7, 6, 2, 4, 11, 15, 16 });
        }

        public static int[] GetPositionValues(int[] position)
        {
            int[] result = new int[position.Length];

            int counter = 1;
            int currentPosition = 0, previousPosition = 0;
            for(int index = 0; index < position.Length; index++)
            {
                counter = 1;
                currentPosition = 0;
                previousPosition = 0;
                while (true)
                {
                    currentPosition = (counter * (counter + 1)) / 2;
                    if (currentPosition >= position[index])
                    {
                        if(position[index] == previousPosition + 1)
                        {
                            result[index] = 1;
                        }
                        else
                        {
                            result[index] = 0;
                        }

                        Console.WriteLine("Input: " + position[index] + " Output: " + result[index]);
                        break;
                    }
                    previousPosition = currentPosition;
                    counter++;
                }

            }

            return result;
        }
    }
}

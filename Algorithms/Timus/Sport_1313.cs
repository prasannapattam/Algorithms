using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1313
    //Displaying a diagonal numbers into a flat structure
    public static class Sport_1313
    {
        public static void Test()
        {
            int[][] input1 = new int[][]
            {
                new int[] {1, 3, 6, 10},
                new int[] {2, 5, 9, 13},
                new int[] {4, 8, 12, 15},
                new int[] {7, 11, 14, 16}
            };

            var result1 = GetResolution(input1);

            int[][] input2 = new int[][]
            {
                new int[] { 1,  3,  6, 10, 15},
                new int[] { 2,  5,  9, 14, 19},
                new int[] { 4,  8, 13, 18, 22},
                new int[] { 7, 12, 17, 21, 24},
                new int[] {11, 16, 20, 23, 25}
            };
            var result2 = GetResolution(input2);
        }

        public static int[] GetResolution(int[][] input)
        {
            int maxLength = input.Length;

            int[] result = new int[maxLength * maxLength];
            int resultCounter = 0;
            int currentBreadth = 0;

            for(int length = 0; length < maxLength; length++)
            {
                for(int breadth = currentBreadth; breadth <= length; breadth++)
                {
                    result[resultCounter] = input[length + currentBreadth - breadth][breadth];
                    resultCounter++;
                }
                if(length == maxLength - 1)
                {
                    currentBreadth++;
                    if (currentBreadth == maxLength)
                        break;
                    length--;
                }

            }


            Console.WriteLine(String.Join(" ", result));
            return result;
        }
    }
}

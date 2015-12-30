using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1319
    //Displaying numbers in diagonal order
    public static class Hotel_1319
    {
        //9:45
        public static void Test()
        {
            GetOrder(4);
            GetOrder(5);
            GetOrder(6);
        }

        public static int[,] GetOrder(int size)
        {
            int[,] forwardArrangement = GetForwardArrangement(size);
            int[,] reverseArrangement = GetReverseArrangement(size);

            //printing
            Console.WriteLine("Size: " + size);
            Console.WriteLine("Forward Order:");
            Display(forwardArrangement);
            Console.WriteLine("Reverse Order:");
            Display(reverseArrangement);

            return forwardArrangement;
        }

        public static int[,] GetForwardArrangement(int size)
        {
            int[,] arrangement = new int[size, size];
            int capacity = size * size;

            int startCol = 0;
            int startRow = 0;

            int row = startRow;
            int col = startCol;

            for (int counter = 0; counter < capacity; counter++)
            {
                arrangement[row, col] = counter + 1;

                if (col == size - 1)
                {
                    startCol++;
                    col = startCol;
                    row = startRow;
                }
                else if(row == 0)
                {
                    startRow++;
                    row = startRow;
                    col = 0;
                }
                else
                {
                    row--;
                    col++;
                }
            }

            return arrangement;
        }

        //public static int[,] GetForwardArrangement(int size)
        //{
        //    int[,] arrangement = new int[size, size];

        //    int currentCol = 0;
        //    int counter = 1;

        //    for (int row = 0; row < size; row++)
        //    {
        //        for (int col = currentCol; col <= row; col++)
        //        {
        //            arrangement[row + currentCol - col, col] = counter;
        //            counter++;
        //        }
        //        if (row == size - 1)
        //        {
        //            currentCol++;
        //            if (currentCol == size)
        //                break;
        //            row--;
        //        }

        //    }

        //    return arrangement;
        //}

        public static int[,] GetReverseArrangement(int size)
        {
            int[,] arrangement = new int[size, size];
            int capacity = size * size;

            int startCol = size - 1;
            int startRow = 0;

            int row = startRow;
            int col = startCol;

            for(int counter = 0; counter < capacity; counter++)
            {
                arrangement[row, col] = counter + 1;

                if(row == size - 1)
                {
                    startRow++;
                    row = startRow;
                    col = 0;
                }
                else if(col == size - 1)
                {
                    row = startRow;
                    startCol--;
                    col = startCol;
                }
                else
                {
                    row++;
                    col++;
                }
            }



            return arrangement;

        }

        public static void Display(int[,] arrangement)
        {
            int size = arrangement.GetUpperBound(0) + 1;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(arrangement[row, col].ToString("00") + " ");
                }

                Console.WriteLine("");
            }
        }
    }
}

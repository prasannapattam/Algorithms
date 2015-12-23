using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1197
    public static class Knight_1197
    {
        public static void Test()
        {

            int[] results = Knight(new ChessBoard('a', 1), new ChessBoard('d', 4), new ChessBoard('g', 6));
            foreach(int result in results)
            {
                Console.WriteLine(result);
            }

        }

        private static int[] Knight(params ChessBoard[] positions)
        {
            int[,] possibleMoves = new int[8, 2] { { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 }, { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 } };
            int xMin = (int) 'a';
            int xMax = (int)'h';
            int yMin = 1;
            int yMax = 8;

            int[] movements = new int[positions.Length];

            for(int counter = 0; counter < positions.Length; counter++)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.Write(((char)positions[counter].X).ToString() + positions[counter].Y.ToString() + " : " );

                int possibleCount = 0;
                for(int moveCount = 0; moveCount <= possibleMoves.GetUpperBound(0); moveCount ++)
                {
                    int xNewPosition = positions[counter].X + possibleMoves[moveCount, 0];
                    int yNewPosition = positions[counter].Y + possibleMoves[moveCount, 1];

                    if (xNewPosition >= xMin && xNewPosition <= xMax && yNewPosition >= yMin && yNewPosition <= yMax)
                    {
                        Console.Write(((char)xNewPosition).ToString() + yNewPosition.ToString() + " ");
                        possibleCount ++;
                    }
                }

                movements[counter] = possibleCount;
                Console.WriteLine("");
            }

            return movements;
        }
        public class ChessBoard
        {
            public ChessBoard(char x, int y)
            {
                X = (int) x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}

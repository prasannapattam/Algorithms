using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1263
    //counting the number of occurances for each number
    public static class Elections_1263
    {
        public static void Test()
        {
            var results = GetVotes(3, new int[] { 1, 2, 3, 2, 1, 1});
        }

        public static decimal[] GetVotes(int candidates, int[] votes)
        {
            decimal[] results = new decimal[candidates];

            foreach(var elector in votes)
            {
                results[elector - 1]++;
            }

            for(int counter = 0; counter < candidates; counter++)
            {
                results[counter] = Math.Round(results[counter] * 100 / votes.Length, 2);
            }

            Console.WriteLine(string.Join(", ", results));

            return results;
        }
    }
}

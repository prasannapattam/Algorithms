using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1910
    public class Entrance_1910
    {
        public static void Test()
        {
            var result1 = GetEntrance(new int[] { 1, 4, 4, 4, 1, 1 });
            var result2 = GetEntrance(new int[] { 2, 4, 1, 4, 7, 8, 8, 9 });
        }

        public static int[] GetEntrance(int[] force)
        {
            int totalForce = 0; //sum of three forces
            int previousTotalForce = 0;
            int forceLocation = 0;

            for(var counter = 0; (counter + 3) <= force.Length; counter++)
            {
                totalForce = force[counter] + force[counter + 1] + force[counter + 2];

                if(totalForce > previousTotalForce)
                {
                    previousTotalForce = totalForce;
                    forceLocation = counter + 2;
                }
            }

            return new int[] { previousTotalForce, forceLocation };
        }
    }
}

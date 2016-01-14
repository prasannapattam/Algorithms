using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1585
    //Getting the max number of occurances in a array for a given number of strings
    public static class Penguin_1585
    {
        public static void Test()
        {
            GetMax(new string[] { "E", "M", "L", "E", "M", "M", "L", "E", "E" });
        }

        public static string GetMax(string[] penguins)
        {
            int emp = 0, mac = 0, lit = 0;
            foreach(var pen in penguins)
            {
                switch (pen)
                {
                    case "E":
                        emp++;
                        break;
                    case "M":
                        mac++;
                        break;
                    case "L":
                        lit++;
                        break;
                }
            }

            string result;
            if (emp > mac && emp > lit)
                result = "Emperor Penguin";
            else if (mac > lit)
                result = "Macaroni Penguin";
            else
                result = "Little Penguin";

            Console.WriteLine(result);
            return result;
        }

    }
}

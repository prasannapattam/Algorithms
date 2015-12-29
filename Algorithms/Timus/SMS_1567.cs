using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=1567
    //SMS and Phone tapping
    public static class SMS_1567
    {
        public static void Test()
        {
            GetCost("pokupaite gvozdi tolko v kompanii gvozdederov i tovarischi!");
        }

        public static int GetCost(string message)
        {
            int cost = 0;
            foreach(char alpha in message.ToCharArray())
            {
                switch (alpha)
                {
                    case 'a':
                    case 'd':
                    case 'g':
                    case 'j':
                    case 'm':
                    case 'p':
                    case 's':
                    case 'v':
                    case 'y':
                    case '.':
                    case ' ':
                        cost += 1;
                        break;
                    case 'b':
                    case 'e':
                    case 'h':
                    case 'k':
                    case 'n':
                    case 'q':
                    case 't':
                    case 'w':
                    case 'z':
                    case ',':
                        cost += 2;
                        break;

                    case 'c':
                    case 'f':
                    case 'i':
                    case 'l':
                    case 'o':
                    case 'r':
                    case 'u':
                    case 'x':
                    case '!':
                        cost += 3;
                        break;
                }
            }

            Console.WriteLine(message + " : " + cost);

            return cost;
        }
    }
}

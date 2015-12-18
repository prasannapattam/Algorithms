using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=2001
    public static class Berry_2001
    {
        public static void Test()
        {
            Basket b = Berry(new Basket(1, 2), new Basket(2, 1), new Basket(0, 3));
            Console.WriteLine(b.M1 + "  " + b.M2);

        }

        private static Basket Berry(Basket b1, Basket b2, Basket b3)
        {
            return new Basket(b1.M1 - b3.M1, b1.M2 - b2.M2);
        }
    }

    public class Basket
    {
        public Basket(int m1, int m2)
        {
            this.M1 = m1;
            this.M2 = m2;
        }
        public int M1 { get; set; }
        public int M2 { get; set; }
    }
}

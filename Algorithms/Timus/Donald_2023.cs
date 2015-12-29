using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    //http://acm.timus.ru/problem.aspx?space=1&num=2023
    //Movements from one point to another point
    public static class Donald_2023
    {
        private static Box[] MailBoxes;
        static Donald_2023()
        {
            MailBoxes = new Box[]
            {
                new Box("Alice", 1),
                new Box("Ariel", 1),
                new Box("Aurora", 1),
                new Box("Phil", 1),
                new Box("Peter", 1),
                new Box("Olaf", 1),
                new Box("Phoebus", 1),
                new Box("Ralph", 1),
                new Box("Robin", 1),

                new Box("Bambi", 2),
                new Box("Belle", 2),
                new Box("Bolt", 2),
                new Box("Mulan", 2),
                new Box("Mowgli", 2),
                new Box("Mickey", 2),
                new Box("Silver", 2),
                new Box("Simba", 2),
                new Box("Stitch", 2),

                new Box("Dumbo", 3),
                new Box("Genie", 3),
                new Box("Jiminy", 3),
                new Box("Kuzko", 3),
                new Box("Kida", 3),
                new Box("Kenai", 3),
                new Box("Tarzan", 3),
                new Box("Tiana", 3),
                new Box("Winnie", 3),
            };
        }

        public static void Test()
        {
            //GetMovements(new string[] { "Aurora", "Tiana", "Ariel", "Mulan" });
            GetMovements(new string[] { "Bambi", "Peter", "Winnie", "Tarzan", "Silver", "Robin" });
        }

        public static int GetMovements(string[] names)
        {
            int movement = 0;
            int currentPosition = 1;
            Box currentBox = null;

            foreach(string name in names)
            {
                for(int counter = 0; counter < MailBoxes.Length; counter++)
                {
                    if(name == MailBoxes[counter].Name)
                    {
                        currentBox = MailBoxes[counter];
                        break;
                    }
                }
                int currentMovements = Math.Abs(currentBox.CaseNumber - currentPosition);
                movement += currentMovements;
                currentPosition = currentBox.CaseNumber;

                Console.WriteLine(currentBox.Name + " : " + currentMovements);
            }
            Console.WriteLine("Total Movements: " + movement);
            return movement;
        }

        public class Box
        {
            public Box(string name, int caseNumber)
            {
                Name = name;
                CaseNumber = caseNumber;
            }

            public string Name { get; set; }
            public int CaseNumber { get; set; }
        }
    }
}

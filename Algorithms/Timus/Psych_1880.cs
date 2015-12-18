using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Timus
{
    public static class Psych_1880
    {
        public static void Test()
        {
            PlayerEigen[] players = new PlayerEigen[]
            {
                new PlayerEigen(new int[] { 13, 20, 22, 43, 100, 101, 146, 150 }),
                new PlayerEigen(new int[] { 10, 11, 13, 22, 101, 146, 150 }),
                new PlayerEigen(new int[] { 13, 22, 43, 67, 89, 101, 120, 146, 150 }),
                new PlayerEigen(new int[] { 13, 101, 120, 149, 151 })
            };

            EigenCountForNPlayers(players);
        }

        public static int EigenCountFor3Players(PlayerEigen[] players)
        {
            int eigenCount = 0;
            int counter = 0;

            while (true)
            {
                //checking for 0 & 1 player
                if(players[0].CurrentValue < players[1].CurrentValue)
                {
                    if (!players[0].MoveNext())
                        break;
                }
                else if (players[1].CurrentValue < players[0].CurrentValue)
                {
                    if (!players[1].MoveNext())
                        break;
                }
                else
                {
                    //checking for the third one
                    if(players[0].CurrentValue == players[2].CurrentValue)
                    {
                        Console.WriteLine(players[0].CurrentValue);
                        eigenCount++;
                        if (!players[0].MoveNext())
                            break;
                        if (!players[1].MoveNext())
                            break;
                        if (!players[2].MoveNext())
                            break;
                    }
                    else if (players[2].CurrentValue < players[0].CurrentValue)
                    {
                        if (!players[2].MoveNext())
                            break;
                    }
                    else
                    {
                        if (!players[0].MoveNext())
                            break;
                        if (!players[1].MoveNext())
                            break;
                    }

                }
                counter++;
            }

            Console.WriteLine("Loop times: " + counter);

            return eigenCount;
        }

        public static int EigenCountForNPlayers(PlayerEigen[] players)
        {
            int eigenCount = 0;
            int counter = 0;
            int playerCount = 1;

            while (true)
            {
                //checking for 0 & 1 player
                if (players[0].CurrentValue < players[playerCount].CurrentValue)
                {
                    playerCount = 1;
                    if (!players[0].MoveNext())
                        break;
                }
                else if (players[playerCount].CurrentValue < players[0].CurrentValue)
                {
                    if (!players[playerCount].MoveNext())
                        break;
                }
                else
                {
                    if(players.Length == playerCount + 1)
                    {
                        Console.WriteLine(players[0].CurrentValue);
                        eigenCount++;
                        playerCount = 1;
                        if (!players[0].MoveNext())
                            break;
                    }
                    else
                    {
                        playerCount++;
                    }
                }
                counter++;
            }

            Console.WriteLine("Loop times: " + counter);

            return eigenCount;
        }

    }

    public class PlayerEigen
    {
        public  PlayerEigen(int[] eigenValues)
        {
            EigenCount = eigenValues.Length;
            EigenValues = eigenValues;
        }

        public int EigenCount { get; set; }
        public int[] EigenValues { get; set; }

        public int CurrentIndex { get; set; }

        public int CurrentValue
        {
            get
            {
                return EigenValues[CurrentIndex];
            }
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            if (EigenCount != CurrentIndex)
                return true;
            else
                return false;
        }
    }
}

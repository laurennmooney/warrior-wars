using System;
using WarriorWars.Enums;

namespace WarriorWars
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Harry", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Voldemort", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

            }
        }
    }
}

using System;
using WCTC_Battle.Models;

namespace WCTC_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Combatant c1 = new Combatant();
            c1.Name = "Fighter Fred";
            c1.Armor.Defense = 10;
            c1.Weapon.Power = 10;

            Enemy c2 = new Enemy();
            c2.Name = "Angry Ant";
            c2.Armor.Defense = 5;
            c2.Weapon.Power = 5;

            c1.Attack(c2);

        }
    }
}

using System;
using WCTC_Battle.Models;

namespace WCTC_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Combatant c1 = new Combatant();
            c1.Name = "c1";
            c1.Armor.Defense = 10;
            c1.Weapon.Power = 10;

            Combatant c2 = new Combatant();
            c2.Name = "c2";
            c2.Armor.Defense = 5;
            c2.Weapon.Power = 5;

            c1.Attack(c2);

        }
    }
}

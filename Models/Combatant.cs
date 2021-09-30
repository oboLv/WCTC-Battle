using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Combatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        public Combatant()
        {
            Armor = new Armor();
            Weapon = new Weapon();
        }
        public void Attack(Enemy enemy)
        {
            if (this.Weapon.Power > enemy.Armor.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with a {this.Weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} dodges the attack by {this.Name}");
            }
        }
    }
}

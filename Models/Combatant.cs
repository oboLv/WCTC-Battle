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
        public void Attack(Combatant c2)
        {
            if (this.Weapon.Power > c2.Armor.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {c2.Name} with a {this.Weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{c2.Name} blocks the attack by {this.Name} with his {c2.Armor.Name}");
            }
        }
    }
}

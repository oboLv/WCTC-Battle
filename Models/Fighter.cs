﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Fighter : ICombatant
    {
        private readonly IArmor _armor;
        private readonly IWeapon _weapon;

        private readonly IPotion _potion;
        
        public string Name { get; set; }

        public Fighter(IArmor armor, IWeapon weapon, IPotion potion)
        {
            _armor = armor;
            _weapon = weapon;
            _potion = potion;
            Name = "Fighter Fred";
        }
        public void Attack(Enemy enemy)
        {
            if (_weapon.Power > enemy.Leather.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with a {_weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} blocks the attack by {this.Name} with his {_armor.Name}");
            }
        }
    }
}

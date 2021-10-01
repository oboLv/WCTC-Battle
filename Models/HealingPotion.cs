using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class HealingPotion : IPotion
    {
        public HealingPotion()
        {
            Name = "Healing Potion";
            
        }

        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Weapon()
        {
            Name = "Weapon";
        }
    }
}

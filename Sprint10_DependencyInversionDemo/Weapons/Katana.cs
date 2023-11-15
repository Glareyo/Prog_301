using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo.Weapons
{
    public class Katana : Weapon
    {
        public Katana()
        {
            this.name = "Katana";
            this.damage = 10;
        }
    }
}

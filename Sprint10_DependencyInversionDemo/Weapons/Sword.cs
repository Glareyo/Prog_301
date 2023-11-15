using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo.Weapons
{
    public class Sword : Weapon
    {
        public Sword() 
        {
            this.name = "Sword";
            this.damage = 3;
        }
    }
}

using Sprint10_DependencyInversionDemo.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo.Character_Classes
{
    public class Samurai : Character
    {
        public Samurai() 
        {
            this.name = "Samurai";
            this.weapon = new Katana();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo
{
    public class Weapon : IWeapon
    {
        protected string name;
        public string Name => this.name;
        protected int damage;
        public int Damage {get=> this.damage; protected set => this.damage = value;}

        public Weapon()
        {
            this.name = "Not a Weapon";
            this.damage = 1;
        }
    }
}

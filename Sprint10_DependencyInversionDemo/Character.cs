using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo
{
    public class Character : ICharacter
    {
        protected string name;
        protected IWeapon weapon;

        public string Name { get => name; set => name = value; }
        public IWeapon Weapon { get => weapon; set => weapon = value; }
    }
}

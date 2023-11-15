﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint10_DependencyInversionDemo
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public IWeapon Weapon { get; set; }
    }
}

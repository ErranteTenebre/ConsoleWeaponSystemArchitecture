using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeaponSystemArchitecture.Base
{
    public class WeaponRarety
    {
        public readonly string name;
        public readonly decimal modifier;
        public readonly decimal creationChance;

        public WeaponRarety(string name, decimal modifier, decimal creationChance)
        {
            this.creationChance = creationChance;
            this.modifier = modifier;
            this.name = name;
        }

    }
}

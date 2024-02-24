using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeaponSystemArchitecture.Base
{
    public abstract class Weapon
    {
        protected readonly WeaponRarety rarety;
        protected readonly int baseDamage;
        protected readonly int range;

        protected Weapon(int range, WeaponRarety rarety, int baseDamage)
        {
            this.range = range;
            this.rarety = rarety;
            this.baseDamage = baseDamage;
        }

        public abstract void Attack();

        protected decimal CalculateTotalDamage()
        {
            return baseDamage * rarety.modifier;
        }

    }
}

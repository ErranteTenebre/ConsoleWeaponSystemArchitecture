using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWeaponSystemArchitecture.Base;

namespace ConsoleWeaponSystemArchitecture.Weapons
{
    public class CrossBow : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine(
                $"Выстрел из арбалета (Редкость оружия -{rarety.name}), урон -{CalculateTotalDamage()}, Радиус -{range}");
        }

        public CrossBow(int range, int baseDamage, WeaponRarety rarety) : base(range, rarety, 200)
        {

        }
    }
}

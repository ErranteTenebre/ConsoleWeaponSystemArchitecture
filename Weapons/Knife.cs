using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWeaponSystemArchitecture.Base;

namespace ConsoleWeaponSystemArchitecture.Weapons
{
    public class Knife : Weapon
    {
        private int _bladeLength;

        public override void Attack()
        {
            Console.WriteLine(
                $"Удар мечом с длинной лезвия{_bladeLength} (Редкость оружия -{rarety.name}), урон -{CalculateTotalDamage()}, Радиус -{range}");
        }

        public Knife(int range, WeaponRarety rarety, int bladeLength) : base(range, rarety, 100)
        {
            _bladeLength = bladeLength;
        }
    }
}

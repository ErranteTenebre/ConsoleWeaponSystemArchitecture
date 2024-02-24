using ConsoleWeaponSystemArchitecture.Base;
using ConsoleWeaponSystemArchitecture.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeaponSystemArchitecture.WeaponFactories
{
    public class CrossBowFactory : WeaponFactory<CrossBow>
    {

        public CrossBowFactory(List<WeaponRarety> rareties) : base(rareties)
        {
        }

        public override CrossBow Create()
        {

            WeaponRarety rarity = GetRarety();

            CrossBow crossBow = new CrossBow(50, 100, rarity);
            return crossBow;
        }
    }
}

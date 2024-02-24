using ConsoleWeaponSystemArchitecture.Base;
using ConsoleWeaponSystemArchitecture.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeaponSystemArchitecture.WeaponFactories
{
    public class KnifeFactory : WeaponFactory<Knife>
    {

        public KnifeFactory(List<WeaponRarety> rareties) : base(rareties)
        {
        }

        public override Knife Create()
        {

            WeaponRarety rarity = GetRarety();

            Knife knife = new Knife(50, rarity, 20);
            return knife;
        }
    }
}

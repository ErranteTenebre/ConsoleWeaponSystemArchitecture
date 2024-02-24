using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeaponSystemArchitecture.Base
{
    public abstract class WeaponFactory<T>
    {
        protected List<WeaponRarety> rareties;

        protected WeaponFactory(List<WeaponRarety> rareties)
        {
            if (rareties.Count == 0)
            {
                throw new Exception("Список редкостей не может быть пустым");
            }
            this.rareties = rareties;   
        }

        public abstract T Create();

        public List<T> CreateList(int length)
        {
            List<T> weapons = new List<T>();

            for (int i = 0; i < length; i++)
            {
                T weapon = Create();

                weapons.Add(weapon);
            }

            return weapons;
        }

        protected WeaponRarety GetRarety()
        {
            decimal totalChance = rareties.Sum(r => r.creationChance);
            decimal randomChance = (decimal)new Random().NextDouble() * totalChance;

            foreach (WeaponRarety rarity in rareties)
            {
                randomChance -= rarity.creationChance;
                if (randomChance <= 0)
                {
                    return rarity;
                }
            }

            return null;
        }
    }
}

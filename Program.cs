using ConsoleWeaponSystemArchitecture.Base;
using ConsoleWeaponSystemArchitecture.WeaponFactories;
using ConsoleWeaponSystemArchitecture.Weapons;

namespace ConsoleWeaponSystemArchitecture;

internal class Program
{
    static void Main(string[] args)
    {
        List<WeaponRarety> weaponRareties = new List<WeaponRarety>()
        {
            new WeaponRarety("Обычный", 1m, 0.4m),
            new WeaponRarety("Редкий", 2m, 2.25m),
            new WeaponRarety("Эпический", 3.5m, 0.15m),
            new WeaponRarety("Легендарный", 5.5m, 0.1m),
            new WeaponRarety("Уникальный", 6.5m, 0.1m),
        };

        KnifeFactory knifeFactory = new KnifeFactory(weaponRareties);
        CrossBowFactory crossBowFactory = new CrossBowFactory(weaponRareties);

        List<Knife> knifeList = knifeFactory.CreateList(20);
        List<CrossBow> crossBowList = crossBowFactory.CreateList(20);

        foreach (Knife knife in knifeList)
        {
            knife.Attack();
        }

        foreach (CrossBow crossBow in crossBowList)
        {
            crossBow.Attack();
        }


    }
}














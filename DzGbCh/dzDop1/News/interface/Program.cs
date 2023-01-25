using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    interface IHasInfo
    {
        void ShowInfo();
    }
    interface IWeapon
    {
        int Damage { get; }
        void Fire();

    }
    abstract class Weapon: IHasInfo, IWeapon
    {
        public abstract int Damage { get; }
        public abstract void Fire();
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage : {Damage}");
        }
    }
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }
        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }
    }
    class Gun : Weapon
    {
        public override int Damage => 7;

        public override void Fire()
        {
            Console.WriteLine("Бах!");
        }
    }
    class LaserGun : Weapon
    {
        public override int Damage => 10;

        public override void Fire()
        {
            Console.WriteLine("Пиу!");
        }
    }

    internal class Program
    {
        static void Main(string[] args) 
        {
            Player player = new Player();
            Weapon[] inventory = { new Gun(), new LaserGun()};
            foreach (var item in inventory)
            {
                    player.CheckInfo(item);
                    player.Fire(item);
                    Console.WriteLine();
            }
        }
    }
}

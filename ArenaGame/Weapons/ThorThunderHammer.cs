using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class ThorThunderHammer : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage {get; private set;}

        public double BlockingPower {get; private set;}

        public double ThunderDamage { get; set;}

        public ThorThunderHammer(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 25;
            ThunderDamage = 40;
        }

        public void SpecialAbility(Hero hero)
        {
            //AttackDamage += ThunderDamage;
            hero.Strenght += ThunderDamage;
            Console.WriteLine($"{hero.Name}'s attack is increased by using of {Name}!");
        }
    }
}

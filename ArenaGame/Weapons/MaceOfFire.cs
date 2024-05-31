using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public  class MaceOfFire : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public double FireDamage { get; set; }

        public MaceOfFire(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 20;
            FireDamage = 15;
        }

        public void SpecialAbility(Hero hero)
        {
            hero.Strenght += FireDamage;
            Console.WriteLine($"{hero.Name}'s attack is increased by using of {Name}!");
        }
    }
}

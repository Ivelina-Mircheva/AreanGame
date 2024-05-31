using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Crossbow : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        
        public double ArrowSpeed { get; private set; }

        public Crossbow(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 5;
            ArrowSpeed = 10;
        }

        public void SpecialAbility(Hero hero)
        {
            hero.Strenght += ArrowSpeed;
            if (ArrowSpeed == 0)
            {
                ArrowSpeed++;
            }
        }
    }
}

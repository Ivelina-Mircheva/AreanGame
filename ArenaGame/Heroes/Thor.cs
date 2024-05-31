using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Thor : Hero
    {
        private double hitCount;
        private double damageCoef;
        private double hammerHit;

        public Thor(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.5;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            double realDamage = damage * damageCoef;
            if (damageCoef < 1) damageCoef += 0.1;
            if(hammerHit == 0)
            {
                hammerHit += 1.5;
            }
            return realDamage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 5)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}

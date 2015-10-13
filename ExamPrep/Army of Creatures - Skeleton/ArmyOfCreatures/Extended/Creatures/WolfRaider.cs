using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended.Creatures
{
    class WolfRaider:Creature
    {
        const int defaultWolfRaiderAttack=8;
        private const int defaultWolfRaiderDefense = 5;
        private const int defaultWolfRaiderHealth = 10;
        private const decimal defaultWolfRaiderDamage = 3.5m;
        private const int WolfRaiderDoubleDamageRounds = 7;

        public WolfRaider() 
            : base(defaultWolfRaiderAttack, defaultWolfRaiderDefense, defaultWolfRaiderHealth, defaultWolfRaiderDamage)
        {
            this.AddSpecialty(new DoubleDamage(WolfRaiderDoubleDamageRounds));
        }
    }
}

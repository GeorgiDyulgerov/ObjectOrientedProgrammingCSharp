using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    class Griffin:Creature
    {
        private const int defaultGriffinAttack = 8;
        private const int defaultGriffinDefense = 8;
        private const int defaultGriffinHealth = 25;
        private const decimal defaultGriffinDamage = 4.5m;
        private const int GriffinDoubleDefenseWhenDefendingRounds = 5;
        private const int GriffinDefenseWhenSkipPoints = 3;


        public Griffin() 
            : base(defaultGriffinAttack, defaultGriffinDefense, defaultGriffinHealth, defaultGriffinDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(GriffinDoubleDefenseWhenDefendingRounds));
            this.AddSpecialty(new AddDefenseWhenSkip(GriffinDefenseWhenSkipPoints));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}

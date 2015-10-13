using System;
using System.Globalization;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Specialties
{
    class DoubleDamage : Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {
            this.Rounds = rounds;
        }

        public int Rounds
        {
            get { return this.rounds; }
            set
            {
                if (value <= 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0 and equal or less than 10");
                }

                this.rounds = value;
            }
        }

        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender,
            decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }
            if (rounds==0)
            {
                return currentDamage;
            }
            currentDamage *= 2;
            rounds--;

            return currentDamage;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {

        }

        public override void ApplyWhenDefending(ICreaturesInBattle defenderWithSpecialty, ICreaturesInBattle attacker)
        {
        }

        public override void ApplyAfterDefending(ICreaturesInBattle defenderWithSpecialty)
        {
            
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
        }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}({1})",
                base.ToString(),
                this.Rounds);
        }
    }
}

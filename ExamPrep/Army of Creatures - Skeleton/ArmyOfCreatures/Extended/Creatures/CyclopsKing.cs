using ArmyOfCreatures.Extended.Specialties;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended.Creatures
{
    class CyclopsKing:Creature
    {
        private const int defaultCyclopsKingAttack = 17;
        private const int defaultCyclopsKingDefense = 13;
        private const int defaultCyclopsKingHealth = 70;
        private const decimal defaultCyclopsKingDamage = 18;
        private const int CyclopsKingAttackPointsWhenSkip = 3;
        private const int CyclopsKingDoubleAttackRounds = 4;
        private const int CyclopsKingDoubleDamageRound = 1;

        public CyclopsKing() 
            : base(defaultCyclopsKingAttack, defaultCyclopsKingDefense, defaultCyclopsKingHealth, defaultCyclopsKingDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(CyclopsKingAttackPointsWhenSkip));
            this.AddSpecialty(new DoubleAttackWhenAttacking(CyclopsKingDoubleAttackRounds));
            this.AddSpecialty(new DoubleDamage(CyclopsKingDoubleDamageRound));
        }
    }
}

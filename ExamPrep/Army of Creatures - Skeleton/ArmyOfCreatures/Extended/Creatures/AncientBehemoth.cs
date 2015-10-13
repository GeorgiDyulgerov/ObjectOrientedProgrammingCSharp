using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    class AncientBehemoth : Creature
    {
        private const int defaultAncientBehemothAttack = 19;
        private const int defaultAncientBehemothDefense = 19;
        private const int defaultAncientBehemothHealth = 300;
        private const decimal defaultAncientBehemothDamage = 40;
        private const decimal AncientBehemothEnemyDefenceReductionPercentage = 80;
        private const int AncientBehemothDoubleDefenceRounds = 5;


        public AncientBehemoth()
            : base(defaultAncientBehemothAttack, defaultAncientBehemothDefense, defaultAncientBehemothHealth, defaultAncientBehemothDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(AncientBehemothEnemyDefenceReductionPercentage));
            this.AddSpecialty(new DoubleDefenseWhenDefending(AncientBehemothDoubleDefenceRounds));
        }
    }
}

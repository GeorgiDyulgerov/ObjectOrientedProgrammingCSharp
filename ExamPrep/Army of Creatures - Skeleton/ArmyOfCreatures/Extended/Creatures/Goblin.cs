using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Extended.Creatures
{
    class Goblin:Creature
    {
        private const int defaultGoblinAttack = 4;
        private const int defaultGoblinDefense = 2;
        private const int defaultGoblinHealth = 5;
        private const decimal defaultGoblinDamage = 1.5m;

        public Goblin() :
            base(defaultGoblinAttack, defaultGoblinDefense, defaultGoblinHealth, defaultGoblinDamage)
        {
        }
    }
}

using System.Reflection;
using WorkWithAbstraction.Interfaces;

namespace WorkWithAbstraction.Characters
{
    class Mage:Character
    {
        private const int defaultMageHealth = 100;
        private const int defaultMageMana = 300;
        private const int defaultMageDamage = 75;
        public Mage() : base(defaultMageHealth, defaultMageMana, defaultMageDamage)
        {
            
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= 2*this.Damage;
        }
    }
}

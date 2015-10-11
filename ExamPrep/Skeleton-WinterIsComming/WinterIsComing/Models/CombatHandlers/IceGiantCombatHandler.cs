using System.Collections.Generic;
using System.Linq;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class IceGiantCombatHandler:CombatHandler
    {
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            if (Unit.HealthPoints<=150)
            {
                return candidateTargets.Take(1);
            }
            return candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            Spell spell=new Stomp();
            if (this.Unit.EnergyPoints < spell.EnergyCost)
            {
                throw new NotEnoughEnergyException(string.Format(
                    GlobalMessages.NotEnoughEnergy,
                    this.Unit.Name, spell.GetType().Name));
            }

            this.Unit.EnergyPoints -= spell.EnergyCost;

            spell.Damage = this.Unit.AttackPoints;
            this.Unit.AttackPoints += 5;
            return spell;
        }
    }
}

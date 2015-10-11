using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class MageCombatHandler:CombatHandler
    {
        private int spellCount;
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            return candidateTargets.OrderByDescending(u => u.HealthPoints).ThenBy(u => u.Name).Take(3);
        }

        public override ISpell GenerateAttack()
        {
            ISpell attack;

            if (this.spellCount % 2 == 0)
            {
                attack = new FireBreath(this.Unit.AttackPoints);
            }
            else
            {
                attack = new Blizzard(this.Unit.AttackPoints * 2);
            }

            if (this.Unit.EnergyPoints < attack.EnergyCost)
            {
                throw new NotEnoughEnergyException(string.Format(
                    GlobalMessages.NotEnoughEnergy,
                    this.Unit.Name, attack.GetType().Name));
            }

            this.spellCount++;

            this.Unit.EnergyPoints -= attack.EnergyCost;

            return attack;
        }
    }
}

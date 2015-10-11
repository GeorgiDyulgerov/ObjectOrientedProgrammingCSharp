using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class WarriorCombatHandler : CombatHandler
    {

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            return candidateTargets
                .OrderBy(t => t.HealthPoints)
                .ThenBy(t => t.Name)
                .Take(1);
        }

        protected int AttackDamage
        {
            get
            {
                int damage = this.Unit.AttackPoints;
                if (this.Unit.HealthPoints <= 80)
                {
                    damage += this.Unit.HealthPoints * 2;
                }

                return damage;
            }
        }

        public override ISpell GenerateAttack()
        {
            var attack = new Cleave(this.AttackDamage);

            if (this.Unit.HealthPoints > 50)
            {
                if (this.Unit.EnergyPoints < attack.EnergyCost)
                {
                    throw new NotEnoughEnergyException(string.Format(
                        GlobalMessages.NotEnoughEnergy,
                        this.Unit.Name, attack.GetType().Name));
                }

                this.Unit.EnergyPoints -= attack.EnergyCost;
            }

            return attack;
        }
    }
}

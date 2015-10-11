using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.CombatHandlers
{
    abstract class CombatHandler:ICombatHandler
    {
        public IUnit Unit { get; set; }
        public virtual IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            throw new NotImplementedException();
        }

        public virtual ISpell GenerateAttack()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class Mage:Unit
    {
        private const int MageAttack = 80;
        private const int MageHealth = 80;
        private const int MageDefense = 40;
        private const int MageEnergy = 120;
        private const int MageRange = 2;

        public Mage(int x, int y, string name)
            : base(x, y, name,
            MageAttack,
            MageHealth,
            MageDefense,
            MageEnergy,
            MageRange,
            new MageCombatHandler())
        {
        }

    }
}

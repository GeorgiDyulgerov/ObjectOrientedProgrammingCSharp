using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class Warrior:Unit
    {
        private const int WarriorAttack = 120;
        private const int WarriorHealth = 180;
        private const int WarriorDefense = 70;
        private const int WarriorEnergy = 60;
        private const int WarriorRange = 1;

        public Warrior(int x, int y, string name)
            : base(x, y, name,
            WarriorAttack,
            WarriorHealth,
            WarriorDefense,
            WarriorEnergy,
            WarriorRange,
            new WarriorCombatHandler())
        {
        }

    }
}

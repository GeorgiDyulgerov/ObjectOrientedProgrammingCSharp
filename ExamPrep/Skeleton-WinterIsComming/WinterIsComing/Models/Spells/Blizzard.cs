using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class Blizzard : Spell
    {
        public Blizzard(int damage)
        {
            this.Damage = damage;
            this.EnergyCost = 40;
        }
    }
}

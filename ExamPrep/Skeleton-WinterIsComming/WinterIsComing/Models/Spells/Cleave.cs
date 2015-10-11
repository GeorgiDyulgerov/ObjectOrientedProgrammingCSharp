using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class Cleave:Spell
    {
        public Cleave(int damage)
        {
            this.Damage = damage;
            this.EnergyCost = 15;
        }
    }
}

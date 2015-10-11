using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    class FireBreath:Spell
    {
        public FireBreath(int damage)
        {
            this.Damage = damage;
            this.EnergyCost = 30;
        }
    }
}

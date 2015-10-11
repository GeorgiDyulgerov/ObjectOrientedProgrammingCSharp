using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    abstract class Spell:ISpell
    {
        protected Spell()
        {

        }
        public int Damage { get;  set; }
        public int EnergyCost { get;  set; }
    }
}

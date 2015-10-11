using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    class Cruiser:Starships
    {
        public Cruiser(string name, int health, int shields, int damage, double fuel, StarSystem locationStarSystem)
            : base(name, 100, 100, 50, 300, locationStarSystem)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}

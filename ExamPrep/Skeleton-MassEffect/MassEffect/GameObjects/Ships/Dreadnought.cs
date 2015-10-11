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
    class Dreadnought:Starships
    {
        public Dreadnought(string name, int health, int shields, int damage, double fuel, StarSystem locationStarSystem)
            : base(name, 200, 300, 150, 700, locationStarSystem)
        {
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            attack.Hit(this);
            this.Shields -= 50;
            if (this.Shields<0)
            {
                this.Shields = 0;
            }
        }

        public override IProjectile ProduceAttack()
        {
            return new Laser((this.Shields/2)+this.Damage);

        }
    }
}

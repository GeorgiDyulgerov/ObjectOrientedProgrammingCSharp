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
    class Frigate : Starships
    {
        private int projectileCounter;
        public Frigate(string name, int health, int shields, int damage, double fuel, StarSystem locationStarSystem)
            : base(name, 60, 50, 30, 220, locationStarSystem)
        {
            this.projectileCounter = 0;
        }

        public override IProjectile ProduceAttack()
        {
            this.projectileCounter++;
            return new ShieldReaver(this.Damage);

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            if (this.Health > 0)
            {
                output.Append(String.Format("-Projectiles fired: {0}", this.projectileCounter));
            }

            return output.ToString();
        }
    }
}

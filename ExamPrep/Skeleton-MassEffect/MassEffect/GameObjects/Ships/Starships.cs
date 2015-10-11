using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    abstract class Starships:IStarship
    {
        private readonly IList<Enhancement> enhancements;
        protected Starships(string name,int health,int shields,int damage,double fuel, StarSystem locationStarSystem)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = locationStarSystem;
            enhancements=new List<Enhancement>();

        }

        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancements;
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            this.enhancements.Add(enhancement);
            this.Shields += enhancement.ShieldBonus;
            this.Damage += enhancement.DamageBonus;
            this.Fuel += enhancement.FuelBonus;

        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Shields { get; set; }

        public int Damage { get; set; }

        public double Fuel { get; set; }

        public StarSystem Location { get; set; }

        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
            attack.Hit(this);
        }

        public override string ToString()
        {
            StringBuilder output=new StringBuilder();

            output.AppendLine(String.Format("--{0} - {1}", this.Name, this.GetType().Name));

            if (this.Health==0)
            {
                output.Append("(Destroyed)");
            }
            else
            {
                output.AppendLine(String.Format("-Location: {0}", this.Location.Name));
                output.AppendLine(String.Format("-Health: {0}",this.Health));
                output.AppendLine(String.Format("-Shields: {0}",this.Shields));
                output.AppendLine(String.Format("-Damage: {0}",this.Damage));
                output.AppendLine(String.Format("-Fuel: {0:##.0}",this.Fuel));

                string enhancementOutput = "N/A";
                if (this.enhancements.Any())
                {
                    enhancementOutput = string.Join(", ",this.enhancements.Select(e=>e.Name));
                }
                output.Append(String.Format("-Enhancements: {0}", enhancementOutput));
                
            }
            return output.ToString();
        }
    }
}

using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class AttackCommand : Command
    {
        public AttackCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string attackerName = commandArgs[1];
            string targetName = commandArgs[2];

            var attacker = this.GameEngine.Starships.First(s => s.Name == attackerName);
            var target = this.GameEngine.Starships.First(t => t.Name == targetName);
            if (attacker.Health == 0 || target.Health == 0)
            {
                Console.WriteLine(Messages.ShipAlreadyDestroyed);
            }
            else if (!target.Location.Equals(attacker.Location))
            {
                Console.WriteLine(Messages.NoSuchShipInStarSystem);
            }
            else
            {
                var attack = attacker.ProduceAttack();
                target.RespondToAttack(attack);

                Console.WriteLine(Messages.ShipAttacked, attackerName, targetName);

                if (target.Health <= 0)
                {
                    target.Health = 0;
                    Console.WriteLine(Messages.ShipDestroyed, targetName);
                }

                if (target.Shields <= 0)
                {
                    target.Shields = 0;
                }
            }




        }
    }
}

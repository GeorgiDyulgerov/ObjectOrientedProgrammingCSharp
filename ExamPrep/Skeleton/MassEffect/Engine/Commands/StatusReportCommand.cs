using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class StatusReportCommand : Command
    {
        public StatusReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArg)
        {
            string shipName = commandArg[1];

            var ship = this.GameEngine.Starships.First(s => s.Name == shipName);

            Console.WriteLine(ship.ToString());

        }
    }
}

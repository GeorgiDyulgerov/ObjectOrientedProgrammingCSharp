using System;
using System.Linq;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArg)
        {
            string shipName = commandArg[1];
            string starSystem = commandArg[2];

            var ship = this.GameEngine.Starships.First(s => s.Name == shipName);
            if (ship.Health == 0)
            {
                Console.WriteLine(Messages.ShipAlreadyDestroyed);
            }
            var startLocation = ship.Location;
            var endLocation = this.GameEngine.Galaxy.GetStarSystemByName(starSystem);
            if (startLocation==endLocation)
            {
                Console.WriteLine(Messages.ShipAlreadyInStarSystem,startLocation.Name);
            }
            else
            {
                this.GameEngine.Galaxy.TravelTo(ship,endLocation);

            if (ship.Location==endLocation)
            {
                Console.WriteLine(Messages.ShipTraveled,shipName,startLocation.Name,endLocation.Name);
            }

            }
            
        }
    }
}

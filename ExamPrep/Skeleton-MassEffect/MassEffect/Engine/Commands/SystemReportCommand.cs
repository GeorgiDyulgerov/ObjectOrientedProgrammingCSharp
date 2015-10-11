using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MassEffect.Interfaces;

namespace MassEffect.Engine.Commands
{
    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArg)
        {
            List<IStarship> allStarships = this.GameEngine.Starships.OrderBy(s => s.Health).ToList();
            List<IStarship> intactStarships = new List<IStarship>();
            List<IStarship> destroyedStarships = new List<IStarship>();
            intactStarships = intactStarships.OrderByDescending(s => s.Health).ToList();
            destroyedStarships = destroyedStarships.OrderBy(s => s.Name).ToList();

            StringBuilder output = new StringBuilder();

            foreach (var starship in allStarships)
            {
                if (starship.Location.Name == commandArg[1])
                {
                    if (starship.Health != 0)
                    {
                        intactStarships.Add(starship);
                    }
                    else if (starship.Health == 0)
                    {
                        destroyedStarships.Add(starship);
                    }
                }
            }
            Console.WriteLine("Intact ships:");
            if (intactStarships.Count == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                foreach (var starship in intactStarships)
                {
                    Console.WriteLine(starship.ToString());
                }
            }

            Console.WriteLine("Destroyed ships:");
            if (destroyedStarships.Count == 0)
            {
                Console.WriteLine("N/A");
            }
            else
            {
                foreach (var destroyedStarship in destroyedStarships)
                {
                    Console.WriteLine(destroyedStarship.ToString());
                }
            }


        }

    }
}

namespace Composite
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Coach' class
    /// </summary>
    public class Coach
        : ComponentAthlete
    {
        private ICollection<ComponentAthlete> players;

        public Coach(string name)
            :base(name)
        {
            this.players = new List<ComponentAthlete>();
        }

        public override void Add(ComponentAthlete player)
        {
            this.players.Add(player);
        }

        public override void Remove(ComponentAthlete player)
        {
            this.players.Remove(player);
        }
        
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name + " is training.");
            Console.WriteLine(new string('-', depth) + "He coaches " + players.Count + " players:");

            foreach (ComponentAthlete athlete in players)
            {
                athlete.Display(depth + 4);
            }
        }
    }
}

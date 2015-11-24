namespace Composite
{
    using System;

    /// <summary>
    /// The 'Player' class
    /// </summary>
    public class Player
        : ComponentAthlete
    {
        public Player(string name)
            : base(name)
        {

        }

        public override void Add(ComponentAthlete player)
        {
            Console.WriteLine("Player cannot add athletes.");
        }

        public override void Remove(ComponentAthlete player)
        {
            Console.WriteLine("Player cannot add athletes.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name + " is training.");
        }
    }
}

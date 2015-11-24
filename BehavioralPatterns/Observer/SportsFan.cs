namespace Observer
{
    using System;

    public class SportsFan : ISportsFan
    {
        public SportsFan(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Player FavoritePlayer { get; set; }

        public void Update()
        {
            Console.WriteLine("To {0} is send an update. {1}'s score is already {2}", this.Name, FavoritePlayer.Name, FavoritePlayer.Score);
        }
    }
}

namespace Observer
{
    using System.Collections.Generic;

    public class Player
    {
        private int score;
        private List<ISportsFan> fans = new List<ISportsFan>();

        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
        }

        public string Name { get; set; }

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value >= 0)
                {
                    this.score = value;
                    this.Notify();
                }
            }
        }

        public void Add(ISportsFan fan)
        {
            if (fan != null)
            {
                fan.FavoritePlayer = this;
                this.fans.Add(fan);
            }
        }

        public void Remove(ISportsFan fan)
        {
            if (fan != null)
            {
                fan.FavoritePlayer = null;
                this.fans.Remove(fan);
            }
        }

        public void Notify()
        {
            foreach (var fan in fans)
            {
                fan.Update();
            }
        }
    }
}

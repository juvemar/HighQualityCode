namespace Observer
{
    public interface ISportsFan
    {
        Player FavoritePlayer { get; set; }

        void Update();
    }
}

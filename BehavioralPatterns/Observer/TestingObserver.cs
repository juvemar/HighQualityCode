namespace Observer
{
    using System;

    public class TestingObserver
    {
        static void Main()
        {
            Player theBestPlayer = new Player("Petio");

            ISportsFan firstFanEver = new SportsFan("Del Piero");
            ISportsFan bestFanEver = new SportsFan("Raul");

            theBestPlayer.Add(firstFanEver);
            theBestPlayer.Add(bestFanEver);

            Console.WriteLine(theBestPlayer.Score);

            theBestPlayer.Score = 45;

            Console.WriteLine();

            theBestPlayer.Score = 0;
        }
    }
}

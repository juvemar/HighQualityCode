namespace Composite
{
    using System;
    
    public class TestingCompositePattern
    {
        public static void Main()
        {
            var coach = new Coach("Shefchev");
            var firstPlayer = new Player("Minchev");
            var secoondPlayer = new Player("Ginchev");
            var thirdPlayer = new Player("Tinchev");

            coach.Add(firstPlayer);
            coach.Add(secoondPlayer);
            coach.Add(thirdPlayer);

            coach.Display(4);
        }
    }
}

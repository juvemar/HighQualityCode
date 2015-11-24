namespace Mediator
{
    public class TestingMediator
    {
        static void Main()
        {
            IPlaneTower tower = new PlaneTower();

            AbstractPlane firstPlane = new BoingPlane("ForMammaRussia");
            AbstractPlane secondPlane = new AirbusPlane("TitanicPlane");
            AbstractPlane thirdPlane = new BoingPlane("NoToTerorism");
            AbstractPlane fourthPlane = new AirbusPlane("NoToRacism");
            AbstractPlane fifthPlane = new AirbusPlane("Fenix");

            tower.Register(firstPlane);
            tower.Register(secondPlane);
            tower.Register(thirdPlane);
            tower.Register(fourthPlane);
            tower.Register(fifthPlane);

            firstPlane.Send("TitanicPlane", "Hello, Jane!");
            secondPlane.Send("NoToTerorism", "11/09");
            thirdPlane.Send("NoToRacism", "White can't jump");
            fourthPlane.Send("Fenix", "Fly, birdy, fly!");
            fifthPlane.Send("ForMammaRussia", "Drujina Sbornaq");
        }
    }
}

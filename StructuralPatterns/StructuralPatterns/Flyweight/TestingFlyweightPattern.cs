namespace Flyweight
{
    public class TestingFlyweightPattern
    {
        public static void Main()
        {
            Color blue = new RedColor();
            Color red = new BlueColor();

            var factory = new ColorFactory();
            var existingColor = factory.GetColor("blue");
            existingColor.Display();

            var newColor = factory.GetColor("red");
            newColor.Display();
        }
    }
}

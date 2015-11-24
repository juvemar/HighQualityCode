namespace Flyweight
{
    using System;

    /// <summary>
    ///A 'ConcreteFlyweight' class 
    /// </summary>
    public class BlueColor : Color
    {
        public BlueColor()
        {
            this.Brightness = 45.2;
            this.Saturation = 10.8;
            this.ColorType = "blue";
        }

        public override void Display()
        {
            Console.WriteLine("This is a {0} color with brightness = {1} and saturation = {2}."
                , this.ColorType, this.Brightness, this.Saturation);
        }
    }
}

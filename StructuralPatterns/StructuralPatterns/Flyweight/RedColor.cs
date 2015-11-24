namespace Flyweight
{
    using System;
 
    /// <summary>
    ///A 'ConcreteFlyweight' class 
    /// </summary>
    public class RedColor : Color
    {
        public RedColor()
        {
            this.Brightness = 55.5;
            this.Saturation = 10.2;
            this.ColorType = "red";
        }

        public override void Display()
        {
            Console.WriteLine("This is a {0} color with brightness = {1} and saturation = {2}."
                , this.ColorType, this.Brightness, this.Saturation);
        }
    }
}

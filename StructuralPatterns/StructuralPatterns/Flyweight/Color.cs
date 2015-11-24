namespace Flyweight
{
    /// <summary>
    /// The abstract 'Flyweight' class
    /// </summary>
    public abstract class Color
    {
        protected double Brightness { get; set; }

        protected double Saturation { get; set; }

        protected string ColorType { get; set; }

        public abstract void Display();
    }
}

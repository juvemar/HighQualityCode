namespace Mediator
{
    using System;
    /// <summary>
    /// The concrete "BoingPlane" class
    /// </summary>
    public class BoingPlane : AbstractPlane
    {
        public BoingPlane(string name)
            :base(name)
        {

        }

        public override void Receive(string fromPlane, string toPlane, string message)
        {
            Console.WriteLine("This is " + this.Name);
            base.Receive(fromPlane, toPlane, message);
        }
    }
}

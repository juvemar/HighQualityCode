namespace Mediator
{
    using System;
    /// <summary>
    /// The concrete "AirbusPlane" class
    /// </summary>
    public class AirbusPlane : AbstractPlane
    {
        public AirbusPlane(string name)
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

namespace Mediator
{
    using System;
    /// <summary>
    /// The Abstract "AbstractPlane" class
    /// </summary>
    public abstract class AbstractPlane
    {
        private string name;

        public AbstractPlane(string name)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } }

        public PlaneTower Tower { get; set; }

        public void Send(string name, string message)
        {
            this.Tower.SendMessage(this.Name, name, message);
        }

        public virtual void Receive(string fromPlane, string toPlane, string message)
        {
            Console.WriteLine("{0} send info to {1}: {2}", fromPlane, toPlane, message);
        }
    }
}

namespace Mediator
{
    using System.Collections.Generic;
    /// <summary>
    /// The "PlaneTower" class
    /// </summary>
    public class PlaneTower : IPlaneTower
    {
        private Dictionary<string, AbstractPlane> activePlanes = new Dictionary<string, AbstractPlane>();

        public void Register(AbstractPlane plane)
        {
            if (!this.activePlanes.ContainsValue(plane))
            {
                this.activePlanes[plane.Name] = plane;
            }

            plane.Tower = this;
        }

        public void SendMessage(string sender, string receiver, string message)
        {
            var receivingPlane = this.activePlanes[receiver];

            if (receivingPlane != null)
            {
                receivingPlane.Receive(sender, receiver, message);
            }
        }
    }
}

namespace Bridge
{
    using System;

    public class VirtualObject : DataObject
    {
        public override void Buy()
        {
            Console.WriteLine("The virtual object was bought!");
        }

        public override void Borrow()
        {
            Console.WriteLine("The virtual object was borrowed!");
        }

        public override void Return()
        {
            Console.WriteLine("The virtual object was returned!");
        }
    }
}

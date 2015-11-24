namespace Bridge
{
    using System;

    public class PhysicalObject : DataObject
    {
        public override void Buy()
        {
            Console.WriteLine("The physical object was bought!");
        }

        public override void Borrow()
        {
            Console.WriteLine("The physical object was borrowed!");
        }

        public override void Return()
        {
            Console.WriteLine("The physical object was returned!");
        }
    }
}

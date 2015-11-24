namespace Bridge
{
    public class Program
    {
        static void Main()
        {
            ClientRepository client = new IndividualClient();
            DataObject obj = new PhysicalObject();

            client.Buy(obj);
            client.Borrow(obj);
        }
    }
}

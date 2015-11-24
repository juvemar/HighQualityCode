namespace Bridge
{
    public class IndividualClient : ClientRepository
    {
        public override void Buy(DataObject obj)
        {
            obj.Buy();
        }

        public override void Borrow(DataObject obj)
        {
            obj.Borrow();
        }

        public override void DoClaim(DataObject obj)
        {
            obj.Return();
        }
    }
}

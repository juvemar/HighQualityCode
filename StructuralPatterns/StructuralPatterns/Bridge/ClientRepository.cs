namespace Bridge
{
    public abstract class ClientRepository
    {
        public abstract void Buy(DataObject obj);

        public abstract void Borrow(DataObject obj);

        public abstract void DoClaim(DataObject obj);
    }
}

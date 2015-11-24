namespace Mediator
{
    public interface IPlaneTower
    {
        void Register(AbstractPlane plane);

        void SendMessage(string sender, string receiver, string message);
    }
}

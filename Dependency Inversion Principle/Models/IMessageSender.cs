namespace Dependency_Inversion_Principle
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string logText);
    }
}
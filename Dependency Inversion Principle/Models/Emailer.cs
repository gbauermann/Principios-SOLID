using System;

namespace Dependency_Inversion_Principle
{
    public class Emailer : IMessageSender
    {

        public void SendMessage(IPerson person, string logText)
        {
            Console.WriteLine($"Enviando email para {person.EmailAddress} informando que {logText}");
        }
    }
}
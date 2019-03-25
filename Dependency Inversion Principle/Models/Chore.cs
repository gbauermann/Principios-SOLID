using System;

namespace Dependency_Inversion_Principle
{
    public class Chore : IChore
    {

        ILogger logger;
        IMessageSender messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public decimal HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger pLogger, IMessageSender pMessageSender)
        {
            logger = pLogger;
            messageSender = pMessageSender;
        }

        public void PerformedWork(decimal hours)
        {
            HoursWorked += hours;            
            logger.Log($"Executada tarefa {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            var logText = $"Tarefa {ChoreName} concluída";
            logger.Log(logText);

            messageSender.SendMessage(Owner, logText);
        }
    }
}
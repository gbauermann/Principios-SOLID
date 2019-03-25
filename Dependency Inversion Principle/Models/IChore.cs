namespace Dependency_Inversion_Principle
{
    public interface IChore
    {
        string ChoreName { get; set; }
        decimal HoursWorked { get; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(decimal hours);
    }
}
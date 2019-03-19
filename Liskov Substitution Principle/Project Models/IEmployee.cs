namespace Liskov_Substitution_Principle
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }

        void CalculateRatePerHour(int rank);
    }
}
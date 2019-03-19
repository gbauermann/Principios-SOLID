namespace Liskov_Substitution_Principle
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
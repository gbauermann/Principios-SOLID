namespace Dependency_Inversion_Principle
{
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirtName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
    }
}
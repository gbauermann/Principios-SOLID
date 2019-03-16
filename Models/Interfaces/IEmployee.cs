namespace Models
{
    public interface IEmployee
    {
        string FirtName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        bool IsManager { get; set; }
        bool IsExecutive { get; set; }
}
}
namespace Models
{
    public interface IPerson
    {
        string FirtName { get; set; }
        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}
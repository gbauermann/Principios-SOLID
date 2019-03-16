namespace Models
{
    public class Person : IPerson
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();
    }
}
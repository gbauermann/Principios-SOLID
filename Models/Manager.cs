using System;

namespace Models
{
    public class Manager : IPerson
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}

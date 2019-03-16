using System;


namespace Models
{
    public class ManagerAccounts : IAccounts
    {
        public Employee Create(IPerson person)
        {
            var output = new Employee();

            output.FirtName = person.FirtName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirtName.Substring(0, 1)}{person.LastName}@acmecorp.com";
            output.IsManager = true;

            return output;
        }
    }
}

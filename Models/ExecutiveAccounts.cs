using System;


namespace Models
{
    public class ExecutiveAccounts : IAccounts
    {
        public Employee Create(IPerson person)
        {
            var output = new Employee();

            output.FirtName = person.FirtName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirtName}.{person.LastName}@acme.com";
            output.IsExecutive = true;

            return output;
        }
    }
}

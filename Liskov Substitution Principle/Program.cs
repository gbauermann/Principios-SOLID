using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Uma classe filha deve ter o mesmo comportamento da classe da qual herda
/// </summary>

namespace Liskov_Substitution_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountingVP = new Manager();

            accountingVP.FirstName = "Bruce";
            accountingVP.LastName = "Wayne";
            accountingVP.CalculateRatePerHour(4);

            IManaged emp = new Employee();
            emp.FirstName = "Oliver";
            emp.LastName = "Queen";
            emp.AssignManager(accountingVP);
            emp.CalculateRatePerHour(2);

            Console.WriteLine($"Salário do {emp.FirstName} é de {emp.Salary.ToString("C2")} por hora");
            Console.ReadLine();
        }
    }
}

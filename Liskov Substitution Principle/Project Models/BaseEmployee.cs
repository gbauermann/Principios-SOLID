using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculateRatePerHour(int rank)
        {
            decimal baseAmount = 12.5m;

            Salary = baseAmount + (rank * 2);
        }
    }
}

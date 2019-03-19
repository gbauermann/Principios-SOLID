using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class CEO: BaseEmployee, IManager
    {
        public override void CalculateRatePerHour(int rank)
        {
            decimal baseAmount = 150m;

            Salary = baseAmount + rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Revisando relatório de performance");
        }

        public virtual void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("CEO não possui gerente");
        }

        public void FireSomeone()
        {
            Console.WriteLine("Você está demitido");
        }
    }
}

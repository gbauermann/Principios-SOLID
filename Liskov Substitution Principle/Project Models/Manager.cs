using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Manager : Employee, IManager
    {

        public override void CalculateRatePerHour(int rank)
        {
            decimal baseAmount = 19.75m;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Revisando relatório de performance");
        }
    }
}

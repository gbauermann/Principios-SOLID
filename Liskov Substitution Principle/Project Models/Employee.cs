using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Employee : BaseEmployee, IManaged
    {        
        public IEmployee Manager { get; set; }

        public void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }

    }
}

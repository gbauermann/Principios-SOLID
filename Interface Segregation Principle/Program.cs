using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A aplicação cliente não deve depender de interfaces que não utiliza
/// </summary>
namespace Interface_Segregation_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowbleDVD dvd = new DVD();           
            
            Console.ReadLine();
        }
    }
}

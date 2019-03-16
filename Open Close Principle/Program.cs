
using Models;
using System;
using System.Collections.Generic;
/// <summary>
/// Projeto criado para implementar o Open Close Principle
/// Objetos devem ser abertos para extensões, mas fechados para alterações
/// </summary>
namespace Open_Close_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicants = new List<IPerson>
            {
                new Person{FirtName = "Jonas", LastName = "Prieto"},
                new Person { FirtName = "Sue", LastName = "Storm" },
                new Person { FirtName = "Nancy", LastName = "Roman" },
                new Manager {FirtName = "Bob", LastName = "Esponja"},
                new Executive {FirtName = "Gabriel", LastName = "Bauermann"}
            };

            var employees = new List<IEmployee>();          

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirtName} {emp.LastName}: {emp.EmailAddress} {(emp.IsManager ? "(Gerente)": "")} {(emp.IsExecutive ? "(Executivo)" : "")}");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// As camadas mais altas da aplicação não devem depender das camadas mais baixas, e ambas devem depender apenas de abstrações
/// </summary>
namespace Dependency_Inversion_Principle
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson owner = Factory.CreatePerson();

            owner.FirtName = "Michel";
            owner.LastName = "Michels";
            owner.EmailAddress = "michel.michels@solid.com";
            owner.PhoneNumber = "90989-0987";


            IChore chore = Factory.CreateChore();

            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;


            chore.PerformedWork(3);
            chore.PerformedWork(1.5m);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}

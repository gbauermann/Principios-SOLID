using Models;
using System;


namespace Single_Responsibility_Principle
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            var output = new Person();

            Console.WriteLine("Nome: ");
            output.FirtName = Console.ReadLine();
        
            Console.WriteLine("Sobrenome: ");
            output.LastName = Console.ReadLine();        

            return output;
        }
    }
}

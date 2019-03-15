using System;

namespace Single_Responsibility_Principle
{
    public class AccountGenerator
    {
        public static void Create(Person user)
        {
            Console.WriteLine($"Nome de usuário é {user.FirtName.Substring(0, 1)}{user.LastName}");
        }
    }
}
using System;


namespace Single_Responsibility_Principle
{
    //classe criada para fins didáticos
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Bem vindo à nossa aplicação");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Pressione Enter para encerrar");
            Console.ReadLine();
        }

        public static void DisplayValidadeError(string param)
        {
            Console.WriteLine($"{param} inválido");
        }
    }
}

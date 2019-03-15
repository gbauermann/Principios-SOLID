/// <summary>
/// Implementação do primeiro princípio SOLID: Single Responsability
/// Cada classe não deve ter mais de uma razão para ser alterada
/// </summary>

namespace Single_Responsibility_Principle
{
    class Program
    {               
        static void Main(string[] args)
        {
            //classe criada para exibir mensagem de abertura e fechamento
            StandardMessages.WelcomeMessage();

            //classe criada para leitura dos dados de pessoa
            var user = PersonDataCapture.Capture();

            //classe criada para validadar dados do usuário
            if (!PersonValidator.Validate(user))
            {
                StandardMessages.EndApplication();
                return;
            }

            //classe criada para criar o usuário
            AccountGenerator.Create(user);

            //classe criada para exibir mensagem de abertura e fechamento
            StandardMessages.EndApplication();
        }
    }
}

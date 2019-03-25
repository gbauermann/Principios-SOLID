using System;

namespace Dependency_Inversion_Principle
{
    public class Logger : ILogger
    {

        public void Log(string log)
        {
            Console.WriteLine($"Saída de log >>> {log}");
        }
    }
}
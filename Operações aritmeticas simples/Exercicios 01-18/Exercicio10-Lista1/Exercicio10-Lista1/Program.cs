using System;

namespace Exercicio10_Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar via tecladoo com valor de uma temperatura em graus Celsius,calcular e exibir sua temperatura equivalente em Fahrenheit.
            Double C,F;
            Console.WriteLine("Conversor de temperatura C para °F");
            Console.WriteLine("Digite a temperatura em °C: ");
            C = Convert.ToDouble(Console.ReadLine());
            F=(((C*9)/5) + 32);
            Console.WriteLine("A temperatura em Fahrenheit é: " + F);
            Console.ReadKey();
        }
    }
}

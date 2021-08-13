using System;

namespace Exercício_01_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com a base e a altura de um retângulo, calcular e exibir sua área.
            int a,b,al;
            Console.WriteLine("Digite o valor da base: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            al = Convert.ToInt32(Console.ReadLine());
            a = b * al;
            Console.WriteLine("A área do retângulo é:" +a);
            Console.ReadKey();



        }
    }
}

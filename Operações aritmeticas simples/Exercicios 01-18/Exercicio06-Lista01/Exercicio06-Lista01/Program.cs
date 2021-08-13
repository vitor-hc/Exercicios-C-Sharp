using System;

namespace Exercicio06_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular e exibir a média aritmética de quatro valores quaisquer que serão digitados.
            Double media, v1, v2,v3,v4;
            Console.WriteLine("Digite o valor 1: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 3: ");
            v3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 4: ");
            v4 = Convert.ToDouble(Console.ReadLine());
            media = (v1 + v2 + v3 + v4) / 4;
            Console.WriteLine("A média dos valores é: " + media);
            Console.ReadKey();


        }
    }
}

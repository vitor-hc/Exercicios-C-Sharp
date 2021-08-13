using System;

namespace Exercicio03_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular e exibir a área de um quadrado, a partir do valor de sua diagonal que será digitado.
            Double diagonal, area;
            Console.WriteLine(" Digite o valor da diagonal para saber a area do quadrado:");
            diagonal=Convert.ToDouble(Console.ReadLine());
            area = (Math.Pow(diagonal, 2)) / 2;
            Console.WriteLine("O valor da área do quadrado é: "+area );
            Console.ReadKey();
        }
    }
}

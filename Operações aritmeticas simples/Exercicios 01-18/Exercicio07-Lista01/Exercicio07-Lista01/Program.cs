using System;

namespace Exercicio07_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e exibir a média geométrica de dois valores quaisquer que serão digitados.
            double v1, v2, media;
            Console.WriteLine("Digite o valor 1: ");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor 2: ");
            v2 = Convert.ToDouble(Console.ReadLine());
            media = (Math.Sqrt (v1 * v2));
            Console.WriteLine("A media geométrica é: " + media);
            Console.ReadKey();


        }
    }
}

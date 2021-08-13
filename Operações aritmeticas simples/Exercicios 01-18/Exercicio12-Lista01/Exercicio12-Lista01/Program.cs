using System;

namespace Exercicio12_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular e exibir o volume de um cone a partir dos valores da altura e do raio da base que serão digitados.
            Double r, h, v;
            Console.WriteLine("Digite a altura do cone: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o raio da base do cone: ");
            r = Convert.ToDouble(Console.ReadLine());
            v = (3.14 * (Math.Pow(r, 2))*h) / 3;
            Console.WriteLine("O volume do cone é: "+v);
            Console.ReadKey();
        }
    }
}

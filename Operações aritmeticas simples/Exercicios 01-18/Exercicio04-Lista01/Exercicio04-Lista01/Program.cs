using System;

namespace Exercicio04_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //A partir dos valores da base e altura de um triângulo, calcular e exibir sua área.
            int altura,b,area;
            Console.WriteLine("Digite o valor da base do triângulo: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            altura = Convert.ToInt32(Console.ReadLine());
            area = (b*altura) / 2;
            Console.WriteLine("A área do triângulo é: "+area );
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercicio02_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e exibir a área de um quadrado, a partir do valor de sua aresta que será digitado.
            int aresta, area;
            Console.WriteLine("Digite o valor da aresta do quadrado: ");
            aresta = Convert.ToInt32(Console.ReadLine());
            area = aresta * aresta;
            Console.WriteLine("A área do quadrado é: " + area);
            Console.ReadKey();
        }
    }
}

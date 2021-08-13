using System;

namespace Exercicio14_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e exibir o volume livre de um ambiente que contém uma esfera de raio "r"inscrita em um cubo perfeito de aresta"a". Os valores de "r" e "a" serão digitados.
            Double r, a, l;
            Console.WriteLine("Digite o raio da esfera: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a aresta do cubo: ");
            a = Convert.ToDouble(Console.ReadLine());
            l = ((6 * (Math.Pow (a, 2)))- ((4 * 3.14 * (Math.Pow(r, 3))) / 3));
            if (r <= a / 2)
                Console.WriteLine(" O volume livre do cubo é: " + l);
            else
                Console.WriteLine("Não e possivel realizar o calculo.");

            Console.ReadKey();

        }
    }
}

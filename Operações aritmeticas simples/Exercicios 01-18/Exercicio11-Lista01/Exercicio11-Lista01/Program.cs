using System;

namespace Exercicio11_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // A partir do diâmetro de um círculo que será digitado, calcular e exibir sua área.
            Double diametro,area;
            Console.WriteLine("Digita o diâmetro do circulo para saber sua área: ");
            diametro = Convert.ToDouble(Console.ReadLine());
            area = (Math.Pow(diametro, 2))*3.14  ;
            Console.WriteLine("A área do circulo é :"+area);
            Console.ReadKey();

        }
    }
}

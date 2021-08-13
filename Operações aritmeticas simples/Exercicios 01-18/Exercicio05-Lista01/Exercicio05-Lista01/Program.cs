using System;
using System.Security.Cryptography;

namespace Exercicio05_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calcular e exibir o volume de uma esfera a partir do valor de seu diâmetro que será digitado.
            double volume, diametro;
            Console.WriteLine("Digite o diâmetro da esfera para obter seu volume:");
            diametro = Convert.ToDouble(Console.ReadLine());
            volume = (4*3.14*(Math.Pow(diametro,3)))/3;
            Console.WriteLine("O volume da esfera é de: " + volume);
            Console.ReadKey();
        }
    }
}

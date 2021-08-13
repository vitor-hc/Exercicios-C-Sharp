using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, area;
            Console.WriteLine("Digite a altura do retângulo: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a base do retângulo: ");
            b=Convert.ToInt32(Console.ReadLine());
            area = a * b;
            Console.WriteLine("A área do retângulo é: " + area);
            if (area > 100)
                Console.WriteLine("Terreno grande!!");
            else
                Console.WriteLine("Terreno pequeno!!");
            Console.ReadKey();

        }
    }
}

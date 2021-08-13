using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, area;
            Console.WriteLine("Digite a base do retângulo");
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo");
            a=Convert.ToDouble(Console.ReadLine());
            area = a * b;
            Console.WriteLine("O valor da área do retângulo é: " + area+" m2");
            if (area > 100)
                Console.WriteLine("Terreno grande!!");
            Console.ReadKey();

        }
    }
}

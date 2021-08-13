using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Digite o primeiro número : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
                Console.WriteLine("O primeiro número é o menor");
            else
                Console.WriteLine("O segundo número é o menor");
            Console.ReadKey();
        }
    }
}

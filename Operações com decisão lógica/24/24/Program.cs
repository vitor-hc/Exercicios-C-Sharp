using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o valor A: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor B: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor C: ");
            c=Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("O valor A é o maior.");

            else
                if (b > c)
                Console.WriteLine("O valor B é o maior.");
            else
                Console.WriteLine("O valor C é o maior.");
            Console.ReadKey();

        }
    }
}

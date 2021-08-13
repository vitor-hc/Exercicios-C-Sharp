using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número positivo.");
            n = Convert.ToInt32(Console.ReadLine());

            while (n<0)
            {
                Console.WriteLine("Digite um numero positivo.");
                n = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Número aceito");
            Console.ReadKey();
        }
    }
}

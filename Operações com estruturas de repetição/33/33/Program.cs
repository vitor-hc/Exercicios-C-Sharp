using System;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Digite o valor de a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor de b");
            b = Convert.ToInt32(Console.ReadLine());
            while (b<a)

            {
                Console.WriteLine("Digite o valor de b");
                b = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Valor aceito!!");
            Console.ReadKey();

        }
    }
}

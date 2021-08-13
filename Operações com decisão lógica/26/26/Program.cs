using System;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, t;
            
            Console.WriteLine("Digite o primeiro lado do triângulo: ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo lado do triângulo: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro lado do triângulo: ");
            c=Convert.ToInt32(Console.ReadLine());
            if (a + b >= c && b + c >= a && a + c >= b)
            { if (a != b && a != c && b != c)

                    Console.WriteLine("O triângulo é escaleno.");


                else if (a == b && a == c && c == b)
                    Console.WriteLine("O triângulo é equilátero.");
                else
                    Console.WriteLine("O triângulo é isósceles.");
                                   
             }
            else
            
                Console.WriteLine("Não forma um triângulo ");
            
            Console.ReadKey();
        }
    }
}

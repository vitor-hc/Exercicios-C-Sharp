using System;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, t;
            do
            {
                Console.WriteLine("Digite um número:");
                x = Convert.ToInt32(Console.ReadLine());

            } while (x<=0);                

           


            for ( y = 0; y <= 10; y++)
            {
                t = x * y;
                Console.WriteLine(x + "x" + y + "=" + t);
            }

            Console.ReadKey();
        }
    }
    
}

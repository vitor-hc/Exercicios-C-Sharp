using System;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            int z, x, y, t;
            Console.WriteLine("Digite o intervalo de b");
            z = Convert.ToInt32(Console.ReadLine());
            while (z <= 0)
            {
                Console.WriteLine("Digite um numero para 'a'");
                z = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Digite o intervalo de b");
            x = Convert.ToInt32(Console.ReadLine());
            while (x <= 0) 
            {
                Console.WriteLine("Digite o intervalo de b");
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Digite o intervalo de c");
            y = Convert.ToInt32(Console.ReadLine());
            while (y <= x) 
            {
               
                Console.WriteLine("Digite o intervalo de c");
                y = Convert.ToInt32(Console.ReadLine());
            }


            for (;y>=x ; y--)
            {
               
                    t = z * y;
                    Console.WriteLine(z + "x" + y + "=" + t);
               
                
              
            }
            


            Console.ReadKey();
        }

    }
}

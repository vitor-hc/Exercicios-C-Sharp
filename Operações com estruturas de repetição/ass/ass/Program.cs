using System;

namespace ass
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
           for (i = 1; i <= 20; i = i + 1)
                 {
            for (j = 1; j <= 10; j = j + 1)
                
            Console.WriteLine("{0} x {1} ={2}", i, j, j *i );
                Console.WriteLine("\n");
                Console.WriteLine("Aperte uma tecla para continuar");
                Console.Read();
                Console.Read();
            }
            Console.ReadKey();
        }
    }
}

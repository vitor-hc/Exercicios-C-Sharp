using System;
using System.Security.Cryptography.X509Certificates;

namespace exe
{
    class Program
    {
        static void Main(string[] args)
        {
            int X=0;
            
            while (X<=0)
            {

                Console.WriteLine("Digite um número positivo:");
                X = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Valor aceito!!");

            Console.ReadKey();

        }
    }
}

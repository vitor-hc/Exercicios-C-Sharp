using System;

namespace Exercicio08_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sabendo que uma milha marítima equivale a um mil, oitocentos, e cinquenta e dois metros e que um quilômetro possui mil metros, fazer um programa para... 
            //...converter milhas marítimas em quilômetros
            Double milhas, km;
            Console.WriteLine("Conversor de milhas para quilômetros.");
            Console.WriteLine("milhas: ");
            milhas = Convert.ToDouble(Console.ReadLine());
            km = milhas * 1.852;
            Console.WriteLine("Quilômetros: "+km.ToString("n"));
            Console.ReadKey();

        }
    }
}

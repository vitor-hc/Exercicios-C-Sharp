using System;

namespace ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, soma = 0;
            Console.WriteLine("Digite um valor positivo e menor que 50");
            n = Convert.ToDouble(Console.ReadLine());
            while (n < 0&&n<50)
            {
                Console.WriteLine("Digite um valor positivo e menor que 50");
                n = Convert.ToDouble(Console.ReadLine());
            }

            for (double i = 1; i < n; i++)
            {


                soma = (soma + (Math.Pow(i,2)+1)/ Math.Pow(i,3));

            }
            Console.WriteLine("A soma dos valores é {0}", soma.ToString("N2"));

            Console.ReadKey();
        }
    }
    
}

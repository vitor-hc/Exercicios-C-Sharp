using System;

namespace ex43
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, soma=0;
            Console.WriteLine("Digite um valor positivo e menor que 50");
            n = Convert.ToDouble(Console.ReadLine());
            while (n < 0 && n < 50)
            {
                Console.WriteLine("Digite um valor positivo e menor que 50");
                n = Convert.ToDouble(Console.ReadLine());
            }

            for (double i = 1; i < n; i++)
            {


                soma = soma + i / (i + 1);
                
            }
            Console.WriteLine("A soma dos valores é {0}", soma.ToString("N2"));
           
            Console.ReadKey();
        }
    }
}

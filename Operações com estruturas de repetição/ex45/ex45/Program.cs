using System;

namespace ex45
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, maior = 0,soma=0;

          
            
            for (int i = 0; i <10; i++)
            {
                Console.WriteLine("Digite um numero positivo");
                n = Convert.ToDouble(Console.ReadLine());

                while (n < 0)
                {
                    Console.WriteLine("Erro!!");
                    Console.WriteLine("Digite um numero positivo");
                    n = Convert.ToDouble(Console.ReadLine());
                }
                if (n > maior)
                    maior = n;

                soma = soma + n;
            }

            Console.WriteLine("O maior valor é {0}", maior);
            Console.WriteLine("A soma dos valores é {0}", soma);
            Console.WriteLine("A média aritmética dos valores é {0}",soma / 10);


        }
    }
}

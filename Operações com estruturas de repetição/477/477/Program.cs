using System;

namespace _477
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, maior = 0, menor = 0, soma = 0, media = 0, porc1 = 0, porc2 = 0, n1 = 0, N2 = 0;
            Console.WriteLine("Digite a quantidade dos numeros de 1 a 20.");
            n = Convert.ToDouble(Console.ReadLine());

            while (n >= 20&&n<0)
            {
                Console.WriteLine("Erro!");
                Console.WriteLine("Digite a quantidade correta");
                n = Convert.ToDouble(Console.ReadLine());
            }
           
            for (int i = 1; i <= n; i++)
            {
                int numero = 0;
                Console.WriteLine("Digite um numero");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }
                else
                {
                    menor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }

                media = soma / n;
                soma = soma + numero;

                if (numero > 0)
                {
                    n1++;
                }
                else
                    if (numero < 0)
                    N2++;
            }
            porc1 = (n1 * 100) / n;
            porc2 = (N2 * 100) / n;
            Console.WriteLine("o maior numero é : {0} ", maior);
            Console.WriteLine("o menor numero é : {0} ", menor);
            Console.WriteLine("a soma é {0}", soma);
            Console.WriteLine("a media é {0}", media);
            Console.WriteLine("a porcentagem de numero positivo é {0}", porc1);
            Console.WriteLine("a porcentagem de numero positivo  é {0}", porc2);
            Console.ReadKey();
        }
    }
}

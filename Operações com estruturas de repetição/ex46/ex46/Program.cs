using System;

namespace ex46
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n,a, maior = 0,menor, soma = 0,positivo=0,negativo=0,porc1,porc2,contador=0;

            
            Console.WriteLine("Digite a quantidade de número que deseja precisa ser positivo e menor que 20");
            n = Convert.ToDouble(Console.ReadLine());
            
            while (n >20&&n<0)
            {
                Console.WriteLine("Erro!!");
                Console.WriteLine("Digite um numero positivo e menor que 20");
                n = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Digite o 1º numero");
            a = Convert.ToDouble(Console.ReadLine());
            maior = a;
            menor = a;
            soma = a;
            for (int i = 1; i<n; i++)
            {


                Console.WriteLine("Digite o {0}º numero",i+1);
                a = Convert.ToDouble(Console.ReadLine());


                if (a > maior)
                {
                    maior = a;

                }
                else if (a < menor)
                    menor = a;

                else if (a > 0)
                {
                    positivo++;

                }
                else if (a < 0)
                {
                    negativo++;

                }

                contador++;
                soma = soma + a;
            }
            porc1 = (positivo * 100)  /contador ;
            porc2 = (negativo * 100) / contador;
            Console.WriteLine("O maior valor é {0}", maior);
            Console.WriteLine("A soma dos valores é {0}", soma);
            Console.WriteLine("A média aritmética dos valores é {0}", soma / n);
            Console.WriteLine("A porcentagem dos valores positivos são {0}%",porc1);
            Console.WriteLine("A porcentagem dos valores negativos são {0}%", porc2);
            Console.ReadKey();

        }
    }
}

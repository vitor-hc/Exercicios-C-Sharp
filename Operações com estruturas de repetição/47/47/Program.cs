using System;

namespace _47
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n, media = 0, soma = 0, x1 = 0, x2 = 0, y1, y2, x = 0,menor,maior;
            string continua = "S";

            while (continua == "S")
            {
                Console.WriteLine("Digite quantos numeros deseja calcular 1 a 20");
                n = Convert.ToDouble(Console.ReadLine());
                while (n < 0 && n >= 20)
                {
                    Console.WriteLine("Erro!");
                    Console.WriteLine("Digite o numero novamente de 1 a 20 ");
                    n = Convert.ToDouble(Console.ReadLine());

                }

                menor = 10000;// estou com dificuldade em reconhecer o menor numero. 
                maior = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Digite um valor:");
                    x = Convert.ToDouble(Console.ReadLine());



                    if (x > maior)
                    {
                        maior = x;

                    }
                    else if (x < menor)
                    {
                        menor = x;
                    }
                    soma = soma + x;
                    media = soma / n;

                    if (x > 0)
                    {
                        x1++;


                    }
                    else if (x < 0)
                    {
                        x2++;

                    }


                }
                y1 = (x1 * 100) / n;
                y2 = (x2 * 100) / n;




                Console.Write("O maior é: {0}", maior);
                Console.Write("\nO menor é: {0}", menor);
                Console.Write("\nA soma é: {0}", soma);
                Console.Write("\nA media é: {0}", media);
                Console.WriteLine("\nA porcentagem de numero positivo é {0}", y1);
                Console.WriteLine("A porcentagem de numero positivo  é {0}", y2);

                Console.WriteLine("\nContinua ? [S/N]");
                continua = Console.ReadLine().ToUpper();
                Console.Clear();






            }
        }
    }
}

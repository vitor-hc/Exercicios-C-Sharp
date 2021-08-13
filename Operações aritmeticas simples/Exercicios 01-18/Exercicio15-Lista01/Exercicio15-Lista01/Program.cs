using System;

namespace Exercicio15_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dolares. Calcular e exibir o valor correspondido em reais(R$).
            Double r, d, c;
            Console.WriteLine("Digite a cotação do dólar:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que deseja converte em reais:");
            d = Convert.ToDouble(Console.ReadLine());
            r = c * d;
            Console.WriteLine("Vale: " +"R$"+ r.ToString("n")+" hoje.");
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercicio17_Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar via teclado com dois valores quaisquer "x" e "y". Calcular e exibir X^y pesquisar as funções Exp e Ln.
            Double x1, y,t,r;
            Console.WriteLine("Digite X");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite Y");
            y = Convert.ToDouble(Console.ReadLine());
            t = (Math.Pow(x1,y));
            Console.WriteLine("O resultado é " + t);
            Console.ReadKey();


        }
    }
}

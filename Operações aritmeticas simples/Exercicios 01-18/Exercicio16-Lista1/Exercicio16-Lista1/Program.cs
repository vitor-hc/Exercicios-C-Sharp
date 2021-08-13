using System;
using System.Threading;

namespace Exercicio16_Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar via teclado com valor de um ângulo em graus, calcular e exibir as seguintes funções trigoométricas: Seno, Coseno,Tangente e secante deste ângulo.
            //Lembre-se que uma função triigonometrica trabalha em radianos.
            Double a, s, c, t, se;
            Console.WriteLine("Digite o ângulo que deseja saber as funções trigonometricas:");
            a = Convert.ToDouble(Console.ReadLine());
            s = (Math.Sin((a*Math.PI)/180));
            c = (Math.Cos((a*Math.PI)/180));
            t = (Math.Tan((a*Math.PI)/180));
            se = (1 / Math.Cos((a * Math.PI) / 180));
            Console.WriteLine("Seno do ângulo "+a+" é "+s);
            Console.WriteLine("Coseno do ângulo " + a + " é " + c);
            Console.WriteLine("Tangente do ângulo " + a + " é " + t);
            Console.WriteLine("Secante do ângulo " + a + " é " + se);
            Console.ReadKey();



        }
    }
}

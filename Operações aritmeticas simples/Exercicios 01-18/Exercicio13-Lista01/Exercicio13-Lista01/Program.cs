using System;

namespace Exercicio13_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular e exibir a velocidade final (em km/h) de um automóvel, a partir dos valores da velocidade inicial(em m/s) da aceleração(m/s) e do tempo de percurso(s) que serão digitados.
            Double vf, vi, a, t;
            Console.WriteLine("Digite a velocidade inicial do automóvel (em m/s): ");
            vi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a aceleração do automóvel (em m/s): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o tempo do percurso(em s): ");
            t = Convert.ToDouble(Console.ReadLine());
            vf = (vi + a * t) * 3.6;
            Console.WriteLine("A velocidade final do automóvel é: "+vf+"KM/H");
            Console.ReadKey();
        }
    }
}

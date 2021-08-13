using System;
using System.Security.Cryptography;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, m;
            Console.WriteLine("Digite a nota da primeira prova P1: ");
            n1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova P2: ");
            n2=Convert.ToDouble(Console.ReadLine());
            m = ((n1 + (2 * n2)) / 3);
            if (m >= 5)
                Console.WriteLine("Aluno aprovado!!");
            else
                Console.WriteLine("Aluno nao atingiu a nota minima de aprovação.");
            Console.ReadKey();

        }
    }
}

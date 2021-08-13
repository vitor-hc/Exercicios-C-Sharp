using System;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, m;
            Console.WriteLine("Digite a nota da primeira prova P1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            m = (15-n1 )/ 2;
            Console.WriteLine("A nota da P2 precisa ser no minimo: "+m);
            Console.ReadKey();
        }
    }
}

using System;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            Double l1, l2, l3,r,d,k;
            Console.WriteLine("Digite o primeiro valor: ");
            l1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            l2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            l3=Convert.ToDouble(Console.ReadLine());
            r = Math.Pow(l1, 2) - Math.Pow(l2, 2) + Math.Pow(l3, 2);
            d= Math.Pow(l2, 2) - Math.Pow(l1, 2) + Math.Pow(l3, 2);
            k= Math.Pow(l3, 2) - Math.Pow(l1, 2) + Math.Pow(l3, 2);
            if (r == 0)
                Console.WriteLine("Forma uma triângulo retângulo.");
            else
                if(d==0)
                Console.WriteLine("Forma uma triângulo retângulo.");
            else
                if(k==0)
                Console.WriteLine("Forma uma triângulo retângulo.");
            else
                Console.WriteLine("Não forma uma triângulo retângulo.");

            Console.ReadKey();




        }
    }
}

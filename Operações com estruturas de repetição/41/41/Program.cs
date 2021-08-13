using System;

namespace _41
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1, c=1, d=1,aux=0;
            Console.WriteLine("A sequencia é: 1\nA sequencia é: 1\nA sequencia é: 1");
            for (int i = 0; i <20; i++)
            {
                a = b + c + d;
                aux = b;
                b = a;
                d = c;
               c = aux;
                
               

               
                Console.WriteLine("A sequencia é: " + a);

            }
            Console.ReadKey();
        }
    }
}

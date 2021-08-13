using System;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,s;
            s = 0;
            
            for ( i = 0; i <=100 ; i++)
            {
               s= s + i;
               
            }
            Console.WriteLine("A soma dos numeros positivos de 1 a 100: " + s);
            Console.ReadKey();
        }
    }
}

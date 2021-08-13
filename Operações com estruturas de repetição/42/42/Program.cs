using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace _42
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b =2 , c = 3, d = 3,e=2,tt=0,k=0;
            Console.WriteLine("Digite um numero positivo: ");
            n=Convert.ToInt32(Console.ReadLine());
            while (n>100||n<0)
            {
                Console.WriteLine("Erro!! Digite um numero positivo: ");
                n=Convert.ToInt32(Console.ReadLine());

                
            }
            
            for (int j = 1; j < n; j++)
            {
                a = b + c;
                b = a;
                c = d + e;
                d = c;

                tt +=a;
               k= tt + 2;

                Console.WriteLine("O resultado é " + a);
            }
            Console.WriteLine("Total "  + k);
                    

            


            Console.ReadKey();

        }
    }
}

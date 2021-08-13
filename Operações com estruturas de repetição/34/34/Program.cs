using System;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            char s;
            Console.WriteLine("Digite o sexo 'M' ou 'F':");
            s = Console.ReadKey().KeyChar;
            while (s!='M'&& s!='m' && s!='f' &&  s!='F')
            {
                Console.WriteLine("Digite o sexo 'M' ou 'F':");
                s = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("\nSexo aceito!!");
            Console.ReadKey();

            

        }
    }
}

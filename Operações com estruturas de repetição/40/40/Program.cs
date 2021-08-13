using System;

namespace _40
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=1, b=0, c=0;
            for (int i = 0; i <= 30; i ++)
            {
                c= a + b;
                a = b;
                b = c;

                Console.WriteLine("{0}", c);
                
            }
           
            Console.WriteLine("{0}\n", c);
            Console.ReadKey();
        }
    }
}

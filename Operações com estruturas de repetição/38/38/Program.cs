using System;




namespace _38
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            int t, a;
            for ( a = 1; a <=20; a++)
            {
                for (int x = 1; x <=10 ; x++)
                {
                   
                    Console.WriteLine("{0}x{1}={2}",a,x,a*x);
                    
                }

                Console.WriteLine("\nAperte uma tecla para prosseguir!!\n");
                Console.ReadKey();
               
            }
          
          

            Console.WriteLine("\nAperte uma tecla para sair");
            Console.ReadKey(); 
        }
    }
}

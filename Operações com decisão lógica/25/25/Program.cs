using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            Double peso, altura, mc;
            Console.WriteLine("Digite seu peso em quilos: ");
            peso=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua altura em metros: ");
            altura=Convert.ToDouble(Console.ReadLine());
            mc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O seu índice de massa corporal è: " + mc.ToString("n"));
            
            if (mc < 20)
                Console.WriteLine("Abaixo do peso");
            else
                if ( mc>=20 && mc<25)
                Console.WriteLine("Peso ideal");
           else
                Console.WriteLine("Acima do peso");
            Console.ReadKey();



        }
    }
}

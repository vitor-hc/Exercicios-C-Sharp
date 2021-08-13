using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, vi, t, vf;
            Console.WriteLine("Digite a aceleração: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a velocidade inicial ");
            vi=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o tempo ");
            t=Convert.ToDouble(Console.ReadLine());
            vf = vi + (a * t);
            Console.WriteLine("Velocidade do automóvel é: " + vf+"KM/H");
            if (vf <= 40)
                Console.WriteLine("Veículo muito lento");
            else
                if (vf > 40 && vf <= 60)
                Console.WriteLine("Velocidade permitida");
            else
                if (vf > 60 && vf <= 80)
                Console.WriteLine("Velocidade de cruzeiro");
            else
                if (vf > 80 && vf >= 120)
                Console.WriteLine("Veículo rápido");
            else
                Console.WriteLine("Veículo muito rápido.");
            Console.ReadKey();

        }
    }
}

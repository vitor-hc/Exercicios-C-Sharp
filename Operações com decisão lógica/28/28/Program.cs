using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, p,mc;
            String s;
            Console.WriteLine("Digite a altura: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso: ");
            p=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o sexo 'M' ou 'F': ");
            s=Console.ReadLine();
            mc = p / Math.Pow(a, 2);


            Console.WriteLine("Seu índice de massa corporal é: " + mc.ToString("N"));
            if (s == "M" && mc < 20)
                Console.WriteLine("Abaixo do peso.");
            else
            if (s == "m" && mc < 20)
                Console.WriteLine("Abaixo do peso.");
            else
                if ( s == "M" && mc <= 20||mc<25)
                Console.WriteLine("Peso ideal.");
            else
                if(s == "m" && mc <= 20 || mc < 25)
                Console.WriteLine("Peso ideal.");
            else
                if(s == "m" && mc >= 25)
                Console.WriteLine("Acima do peso.");
            else   
                if ( s == "M" &&  mc >= 25)
                Console.WriteLine("Acima do peso.");
            else
                if (s == "F" && mc < 19)
                Console.WriteLine("Abaixo do peso.");
            else
            if (s == "f" && mc <19 )
                Console.WriteLine("Abaixo do peso.");
            else
                if (s == "F" && mc <= 19|| mc < 24)
                Console.WriteLine("Peso ideal.");
            else
                if (s == "f" && mc <= 19 || mc < 24)
                Console.WriteLine("Peso ideal.");
            else
                if (s == "F" && mc >= 24)
                Console.WriteLine("Acima do peso.");
            else
                if (s == "f" && mc >= 24)
                Console.WriteLine("Acima do peso.");
            Console.ReadKey();





        }
    }
}

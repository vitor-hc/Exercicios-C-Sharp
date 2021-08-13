using System;

namespace Exercicio18_Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrar via teclado com o valor de 5 produtos. Após as entradas, digitar um valor referente ao pagamento da somatoria destes valores. Calcular e exibir o troco que deverá ser devolvido.
            Double v1, v2, v3, v4, v5, tr, tt, dv;
            Console.WriteLine("Digite o valor do produto: ");
            v1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            v2= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            v3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            v4= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            v5= Convert.ToDouble(Console.ReadLine());
            tt = v1 + v2 + v3 + v4 + v5;
            Console.WriteLine("Valor total é: " + tt);
            Console.WriteLine("Digite a quantia que o cliente esta dando para ser feito o calculo do troco:");
            dv = Convert.ToDouble(Console.ReadLine());
            tr = dv - tt;
            Console.WriteLine("O valor a ser devolvido é de: " + tr + " reais.");
            Console.ReadKey();
        }
    }
}

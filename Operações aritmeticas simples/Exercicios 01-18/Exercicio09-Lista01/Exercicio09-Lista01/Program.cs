using System;

namespace Exercicio09_Lista01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular e exibir a tensão de um determinado circuito eletrônico a partir dos valores da resistência e corrente elétrica que serão digitados.Utilize a lei de Ohm.
            Double tensao, resistencia, corrente;
            Console.WriteLine("Calculadora de tensão");
            Console.WriteLine("Digite a resistência: ");
            resistencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a corrente elétrica : ");
            corrente = Convert.ToDouble(Console.ReadLine());
            tensao = corrente * resistencia;
            Console.WriteLine("A tensão do circuito é: "+tensao+"V");
            Console.ReadKey();
        }
    }
}

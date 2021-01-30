using System;
using System.Globalization;

namespace Exercicio_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorPorHora * horasTrabalhadas;

            Console.WriteLine("NUMBER = {0}", numeroFuncionario); 
            Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

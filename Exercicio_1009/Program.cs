using System;
using System.Globalization;

namespace Exercicio_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendasEfetuadas, salarioMes;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendasEfetuadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salarioMes = salarioFixo + (totalVendasEfetuadas * 15 / 100);

            Console.WriteLine("TOTAL = R$ {0}", salarioMes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

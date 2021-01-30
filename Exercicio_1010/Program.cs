using System;
using System.Globalization;

namespace Exercicio_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal;

            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');
                        
            int numeroPecas1 = int.Parse(linha1[1]);
            double valorUnitarioPeca1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);
            
            int numeroPecas2 = int.Parse(linha2[1]);
            double valorUnitarioPeca2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

            valorTotal = (numeroPecas1 * valorUnitarioPeca1) + (numeroPecas2 * valorUnitarioPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

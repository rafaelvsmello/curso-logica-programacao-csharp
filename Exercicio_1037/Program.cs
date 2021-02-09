using System;
using System.Globalization;

namespace Exercicio_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor >= 25.0001 && valor <= 50.0000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor >= 50.0001 && valor <= 75.0000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor >= 75.0001 && valor <= 100.0000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else if (valor < 0 || valor > 100.0001)
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}

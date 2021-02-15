using System;
using System.Globalization;

namespace Exercicio_1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, media;
            int novoCalculo = 1;

            while(novoCalculo == 1)
            {
                p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (p1 <= 0.0 || p1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (p2 <= 0.0 || p2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (p1 + p2) / 2.0;
                Console.WriteLine("media = {0}", media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());

                while (novoCalculo != 1 && novoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
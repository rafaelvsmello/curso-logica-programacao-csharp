using System;
using System.Globalization;

namespace Exercicio_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = (double)4 / 3 * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

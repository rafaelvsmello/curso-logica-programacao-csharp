using System;
using System.Globalization;

namespace Exercicio_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a * 2) + (b * 3) + (c * 5);
            media /= 10;
            Console.WriteLine("MEDIA = {0}", media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Exercicio_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a * 3.5) + (b * 7.5);
            media /= 11;
            Console.WriteLine("MEDIA = {0}", media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}

using System;
using System.Globalization;

namespace Exercicio_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoViagem, velocidadeMedia;
            double litrosNecessarios;

            tempoViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            litrosNecessarios = tempoViagem * velocidadeMedia / (double)12;
            Console.WriteLine(litrosNecessarios.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

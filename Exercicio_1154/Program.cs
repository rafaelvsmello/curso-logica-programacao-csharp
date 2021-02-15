using System;
using System.Globalization;

namespace Exercicio_1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine()), somaIdade, contador;
            double mediaIdade;

            somaIdade = 0;
            contador = 0;

            while(idade >= 0)
            {
                contador++;
                somaIdade += idade;
                idade = int.Parse(Console.ReadLine());
            }

            mediaIdade = (double)somaIdade / contador;
            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

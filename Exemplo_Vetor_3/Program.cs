using System;
using System.Globalization;

namespace Exemplo_Vetor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;
            double soma, media;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] split = Console.ReadLine().Split(' ');

            soma = 0.0;            

            for(int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(split[i], CultureInfo.InvariantCulture);
                soma += vet[i];
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            media = soma / n;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

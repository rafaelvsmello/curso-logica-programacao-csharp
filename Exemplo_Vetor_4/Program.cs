using System;
using System.Globalization;

namespace Exemplo_Vetor_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, idade = 0;
            n = int.Parse(Console.ReadLine());

            double alturaMedia = 0.0;           

            for(int i = 0; i < n; i++)
            {
                string[] split = Console.ReadLine().Split(' ');
                alturaMedia += double.Parse(split[2], CultureInfo.InvariantCulture);

                if (int.Parse(split[1]) < 16) 
                {
                    idade++;
                }
            }

            alturaMedia /= n;

            double porcentagemMenorDezesseis = idade * 100.0 / n;
            Console.WriteLine("Altura média: {0}", alturaMedia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pessoas com menos de 16 anos: {0}%", porcentagemMenorDezesseis.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}

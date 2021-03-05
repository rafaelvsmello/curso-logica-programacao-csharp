using System;
using System.Globalization;

namespace Exercicio_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quantia, c, r, s, cobaias;
            char tipo;

            string[] vet;

            n = int.Parse(Console.ReadLine());

            c = 0;
            r = 0;
            s = 0;
            cobaias = 0;

            for (int i = 1; i <= n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if (tipo == 'C')
                {
                    c += quantia;                    
                }
                else if (tipo == 'R')
                {
                    r += quantia;
                }
                else
                {
                    s += quantia;
                }

                cobaias += quantia;
            }            

            Console.WriteLine("Total: {0} cobaias", cobaias);
            Console.WriteLine("Total de coelhos: {0}", c);
            Console.WriteLine("Total de ratos: {0}", r);
            Console.WriteLine("Total de sapos: {0}", s);
            Console.WriteLine("Percentual de coelhos: {0} %", ((double)c * 100.0 / cobaias).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentual de ratos: {0} %", ((double)r * 100.0 / cobaias).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentual de sapos: {0} %", ((double)s * 100.0 / cobaias).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

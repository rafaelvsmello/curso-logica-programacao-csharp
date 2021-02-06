using System;
using System.Globalization;

namespace Exercicio_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double total = 0.0;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            switch (codigo)
            {
                case 1:
                    total = 4.0 * quantidade;
                    break;
                case 2:
                    total = 4.5 * quantidade;
                    break;
                case 3:
                    total = 5.0 * quantidade;
                    break;
                case 4:
                    total = 2.0 * quantidade;
                    break;
                case 5:
                    total = 1.5 * quantidade;
                    break;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

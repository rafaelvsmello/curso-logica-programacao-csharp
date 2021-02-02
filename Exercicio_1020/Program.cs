using System;

namespace Exercicio_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anos, meses, resto;

            n = int.Parse(Console.ReadLine());

            anos = n / 365;
            resto = n % 365;

            meses = resto / 30;
            resto = resto % 30;

            Console.WriteLine("{0} ano(s)", anos);
            Console.WriteLine("{0} mes(es)", meses);
            Console.WriteLine("{0} dia(s)", resto);
        }
    }
}

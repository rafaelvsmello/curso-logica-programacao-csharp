using System;

namespace Exercicio_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, prod;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            prod = valor1 * valor2;

            Console.WriteLine("PROD = {0}", prod);
        }
    }
}
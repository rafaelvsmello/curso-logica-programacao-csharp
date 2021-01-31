using System;

namespace Exercicio_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maiorAb, maior;
            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            maiorAb = (a + b + Math.Abs(a - b)) / 2;
            maior = (maiorAb + c + Math.Abs(maiorAb - c)) / 2;

            Console.WriteLine("{0} eh o maior", maior);
        }
    }
}

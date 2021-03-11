using System;

namespace Exemplo_Vetor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new int[n];

            string[] split = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                vet[i] = int.Parse(split[i]);
            }

            for(int i = 0; i < n; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }

        }
    }
}

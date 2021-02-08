using System;

namespace Exercicio_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, duracao;
            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else if (inicio > fim)
            {
                duracao = Math.Abs((1440 - ((inicio - fim) * 60)) / 60);                
            }
            else
            {
                duracao = 24;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }

    }
}
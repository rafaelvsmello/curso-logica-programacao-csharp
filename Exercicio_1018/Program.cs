using System;

namespace Exercicio_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nota, quociente, resto;

            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            nota = 100;
            quociente = n / 100;
            resto = n % 100;
            Console.WriteLine("{0} nota(s) de R$ 100,00", quociente);

            nota = 50;
            quociente = resto / 50;
            resto %= 50;
            Console.WriteLine("{0} nota(s) de R$ 50,00", quociente);

            nota = 20;
            quociente = resto / 20;
            resto %= 20;
            Console.WriteLine("{0} nota(s) de R$ 20,00", quociente);

            nota = 10;
            quociente = resto / 10;
            resto %= 10;
            Console.WriteLine("{0} nota(s) de R$ 10,00", quociente);

            nota = 5;
            quociente = resto / 5;
            resto %= 5;
            Console.WriteLine("{0} nota(s) de R$ 5,00", quociente);

            nota = 2;
            quociente = resto / 2;
            resto %= 2;
            Console.WriteLine("{0} nota(s) de R$ 2,00", quociente);

            nota = 1;
            quociente = resto / 1;            
            Console.WriteLine("{0} nota(s) de R$ 1,00", quociente);
        }
    }
}

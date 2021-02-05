using System;
using System.Globalization;

namespace Exercicio_1021
{
    class Program
    {
        static void Main(string[] args)
        {
			double n;
			int quociente, resto, nota, moeda;

			n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			resto = (int)(n * 100 + 0.5);

			Console.WriteLine("NOTAS:");

			nota = 100;
			quociente = resto / (nota * 100);			
			Console.WriteLine("{0} nota(s) de R$ 100.00", quociente);
			resto %= (nota * 100);

			nota = 50;
			quociente = resto / (nota * 100);
			Console.WriteLine("{0} nota(s) de R$ 50.00", quociente);
			resto %= (nota * 100);			

			nota = 20;
			quociente = resto / (nota * 100);
			Console.WriteLine("{0} nota(s) de R$ 20.00", quociente);
			resto %= (nota * 100);			

			nota = 10;
			quociente = resto / (nota * 100);
			Console.WriteLine("{0} nota(s) de R$ 10.00", quociente);
			resto %= (nota * 100);			

			nota = 5;
			quociente = resto / (nota * 100);
			Console.WriteLine("{0} nota(s) de R$ 5.00", quociente);
			resto %= (nota * 100);			

			nota = 2;
			quociente = resto / (nota * 100);
			Console.WriteLine("{0} nota(s) de R$ 2.00", quociente);
			resto %= (nota * 100);			

			Console.WriteLine("MOEDAS:");

			moeda = 100;
			quociente = resto / moeda;
			Console.WriteLine("{0} moeda(s) de R$ 1.00", quociente);
			resto %= moeda;			

			moeda = 50;
			quociente = resto / moeda;
			Console.WriteLine("{0} moeda(s) de R$ 0.50", quociente);
			resto %= moeda;

			moeda = 25;
			quociente = resto / moeda;
			Console.WriteLine("{0} moeda(s) de R$ 0.25", quociente);
			resto %= moeda;

			moeda = 10;
			quociente = resto / moeda;
			Console.WriteLine("{0} moeda(s) de R$ 0.10", quociente);
			resto %= moeda;

			moeda = 5;
			quociente = resto / moeda;
			Console.WriteLine("{0} moeda(s) de R$ 0.05", quociente);
			resto %= moeda;
			
			Console.WriteLine("{0} moeda(s) de R$ 0.01", resto);
		}
    }
}

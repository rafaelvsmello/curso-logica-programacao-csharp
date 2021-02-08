using System;
using System.Globalization;

namespace Exercicio_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario;
            int percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario >= 0 && salario <= 400.00)
            {
                percentual = 15;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 400.01 && salario <= 800.00)
            {
                percentual = 12;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 800.01 && salario <= 1200.00)
            {
                percentual = 10;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                percentual = 7;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;
            }
            else
            {
                percentual = 4;
                reajuste = salario * percentual / 100;
                novoSalario = salario + reajuste;
            }

            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual);
        }
    }
}
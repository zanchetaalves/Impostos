using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Entre com o número de funcionários: ");
            short qtd = short.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Impostos funcionário #{i} dados:");
                Console.Write("Pessoa física ou jurídica (f/j): ");
                char pf = char.Parse(Console.ReadLine());

                if (pf == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Número de funcionários: ");
                    short funcionarios = short.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaJuridica(nome, rendaAnual, funcionarios));
                }
            }

            Console.WriteLine();
            Console.WriteLine("IMPOSTOS PAGOS: ");

            double impostos = 0L;
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p);
                impostos += p.Impostos();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL DE IMPOSTOS: {impostos.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("Teste");
            string teste = Console.ReadLine();
        }
    }
}

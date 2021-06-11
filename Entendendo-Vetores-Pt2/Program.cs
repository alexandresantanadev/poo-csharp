using System;
using Entendendo_Vetores_Pt2.Models;
using System.Globalization;

namespace Entendendo_Vetores_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }

            double media = soma / n;

            System.Console.WriteLine("Preço médio = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

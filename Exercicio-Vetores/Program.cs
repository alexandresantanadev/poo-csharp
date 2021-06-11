using System;
using Exercicio_Vetores.Models;

namespace Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vect = new Pessoa[10];

            System.Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine();
                System.Console.WriteLine($"Aluguel #{i}:");
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();

                System.Console.Write("Email: ");
                string email = Console.ReadLine();

                System.Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Pessoa(nome, email);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    System.Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}

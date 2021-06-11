using System;

namespace Entendendo_Classes
{
    class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        System.Console.WriteLine("Dados da primeira pessoa:");

        System.Console.Write("Nome: ");
        p1.Nome = Console.ReadLine().ToString();

        System.Console.Write("Idade: ");
        p1.Idade = int.Parse(Console.ReadLine().ToString());

        System.Console.WriteLine("Dados da segunda pessoa:");

        System.Console.Write("Nome: ");
        p2.Nome = Console.ReadLine().ToString();

        System.Console.Write("Idade: ");
        p2.Idade = int.Parse(Console.ReadLine().ToString());

        if (p1.Idade > p2.Idade)
        {
            Console.WriteLine("Pessoa mais velha: " + p1.Nome);
        }
        else
        {
            Console.WriteLine("Pessoa mais velha: " + p2.Nome);
        }
    }
}
}


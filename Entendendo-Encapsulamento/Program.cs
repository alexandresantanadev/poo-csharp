using System;
using Entendendo_Encapsulamento.Models;
using System.Globalization;

namespace Entendendo_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");

            System.Console.WriteLine(p.GetNome());
            System.Console.WriteLine(p.GetPreco());
            System.Console.WriteLine(p.GetQuantidade());
        }
    }
}

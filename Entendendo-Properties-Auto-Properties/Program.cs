using System;
using Entendendo_Properties_Auto_Properties.Models;

namespace Entendendo_Properties_Auto_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            System.Console.WriteLine(p.Nome);
            System.Console.WriteLine(p.Preco);
            System.Console.WriteLine(p.Quantidade);
        }
    }
}

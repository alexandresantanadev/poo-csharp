using System;
using System.Globalization;
using Entendendo_Construtores.Models;

namespace Entendendo_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Entre os dados do produto: ");

            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new Produto(nome, preco, quantidade);

            System.Console.WriteLine("Dados do produto: " + produto);

            System.Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int addProd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(addProd);

            System.Console.WriteLine("Dados Atualizados: " + produto);

            System.Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remProd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(remProd);

            System.Console.WriteLine("Dados Atualizados: " + produto);
        }
    }
}

using System;
using System.Globalization;
using Exercicio_Estoque_Produtos.Models;

namespace Exercicio_Estoque_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            System.Console.WriteLine("Entre os dados do produto: ");

            System.Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            System.Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Dados do produto: "+ produto);

            System.Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int addProd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(addProd);
            
            System.Console.WriteLine("Dados Atualizados: "+ produto);

            System.Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int remProd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(remProd);

            System.Console.WriteLine("Dados Atualizados: "+ produto);

        }
    }
}

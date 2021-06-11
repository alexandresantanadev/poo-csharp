using System.Globalization;

namespace Exercicio_Estoque_Produtos.Models
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return "Nome: "
            + Nome
            + ", Preço: R$ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", Quantidade: "
            + Quantidade
            + " unidades"
            + ", Total: R$ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
using System.Globalization;
using System;

namespace Entendendo_Modificadores_de_Acesso.Models
{
    public class Produto
    {

        //public, protected internal, internal, protected, private protected, private.
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            + _nome
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
using System.Globalization;

namespace Exercicios1.Models
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() => Preco * Quantidade;

        public void AdicionarProdutos(int quantidade) => Quantidade += quantidade;
        public void RemoverProdutos(int quantidade) => Quantidade -= quantidade;

        public override string ToString() =>
            $"{Nome}, $ {Preco:F2}, {Quantidade} unidades, total: $ {ValorTotalEmEstoque():F2}";
    }
}
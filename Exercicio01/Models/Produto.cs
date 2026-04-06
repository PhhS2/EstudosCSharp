class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public double ValorTotalEmEstoque() => _preco * _quantidade;

    public void AdicionarProdutos(int quantidade) => _quantidade += quantidade;

    public void RemoverProdutos(int quantidade) => _quantidade -= quantidade;

    public override string ToString() =>
        $"{_nome}, $ {_preco:F2}, {_quantidade} unidades, total: $ {ValorTotalEmEstoque():F2}";
}
namespace AtividadeDiagnostica.Modelos;

internal class Cliente
{
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public string Senha { get; }
    public bool logado { get; set; }
    public CarrinhoDeCompras Carrinho = new();

    public int QuantidadeProdutos => Carrinho.Produtos.Count;

    public Cliente(string nome, string cpf, string senha)
    {
        Nome = nome;
        Cpf = cpf;
        Senha = senha;
    }

    public void AdicionarProduto(Produto produto)
    {
        Carrinho.Produtos.Add(produto);
    }
}

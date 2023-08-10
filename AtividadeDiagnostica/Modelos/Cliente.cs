namespace AtividadeDiagnostica.Modelos;

internal class Cliente
{
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public string Senha { get; }
    public bool Logado { get; set; }

    public CarrinhoDeCompras Carrinho = new();// Todo cliente tem Carrinho próprio

    public int QuantidadeProdutos => Carrinho.Produtos.Count;

    public Cliente(string nome, string cpf, string senha)// Ctor
    {
        Nome = nome;
        Cpf = cpf;
        Senha = senha;
        Logado = false;
    }

    public void AdicionarProduto(Produto produto)
    {
        Carrinho.Produtos.Add(produto);
    }
}

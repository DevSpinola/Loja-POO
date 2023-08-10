using AtividadeDiagnostica.Modelos;
namespace AtividadeDiagnostica.Menus;

internal class MenuMostrarCarrinho : Menu
{
    public override void Executar(Dictionary<int, Produto> listaProdutos, Cliente clientelogado)
    {
        base.Executar(listaProdutos, clientelogado);
        ExibirTituloDaOpcao("Seu Carrinho:");
        clientelogado.Carrinho.Produtos.ForEach(item => // Exibe os produtos no carrinho do cliente logado
        {
            Console.WriteLine($"{clientelogado.Nome} você possui {clientelogado.QuantidadeProdutos} no carrinho: ");
            Console.WriteLine(item.Descricao);
        });
    }
}

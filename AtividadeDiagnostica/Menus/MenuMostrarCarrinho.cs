using AtividadeDiagnostica.Modelos;
namespace AtividadeDiagnostica.Menus;

internal class MenuMostrarCarrinho : Menu
{
    public override void Executar(Dictionary<int, Produto> listaProdutos, Cliente clientelogado)
    {
        base.Executar(listaProdutos, clientelogado);
        ExibirTituloDaOpcao("Seu Carrinho:");
        clientelogado.Carrinho.Produtos.ForEach(item =>
        {
            Console.WriteLine(item.Descricao);
        });
    }
}

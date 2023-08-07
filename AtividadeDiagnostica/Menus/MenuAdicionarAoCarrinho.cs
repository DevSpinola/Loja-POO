using AtividadeDiagnostica.Modelos;

namespace AtividadeDiagnostica.Menus;

internal class MenuAdicionarAoCarrinho : Menu
{
    public override void Executar(Dictionary<int, Produto> listaProdutos, Cliente clientelogado)
    {
        base.Executar(listaProdutos, clientelogado);
        ExibirTituloDaOpcao("Selecione o produto para adicionar ao Carrinho");

        foreach (var item in listaProdutos)
        {
            Console.WriteLine($"{item.Key} - {item.Value.Descricao}");
            
        }
        int produtoEscolhido = int.Parse(Console.ReadLine()!);
        clientelogado.AdicionarProduto(listaProdutos.GetValueOrDefault(produtoEscolhido)!);
        Console.WriteLine($"{listaProdutos[produtoEscolhido].Descricao} adicionado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
    }
}

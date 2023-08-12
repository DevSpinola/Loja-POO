using AtividadeDiagnostica.Modelos;

namespace AtividadeDiagnostica.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<int, Produto> listaProdutos, Cliente? clientelogado)
    {
        base.Executar(listaProdutos, clientelogado);
        Console.WriteLine($"Tchau {clientelogado.Nome}, volte sempre!");
        clientelogado.Logado = false;
        Thread.Sleep( 2000 );
    }
}

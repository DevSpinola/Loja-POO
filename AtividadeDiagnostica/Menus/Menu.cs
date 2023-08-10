namespace AtividadeDiagnostica.Menus;
using AtividadeDiagnostica.Modelos;

internal class Menu // Classe Maior que será herdada nos outros menus
{
    public void ExibirTituloDaOpcao(string titulo) // Método que exibe um titulo formatado no console
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }  
    public virtual void Executar(Dictionary<int, Produto> listaProdutos, Cliente clientelogado)// Método que será herdado nas outras classes menus
    {
        Console.Clear();
    }

}

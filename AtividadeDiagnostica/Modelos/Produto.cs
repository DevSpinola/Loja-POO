namespace AtividadeDiagnostica.Modelos;

internal class Produto
{
   
    public string Descricao { get; set; }

    public Produto(string descricao)// Classe simples que só possui descrição e ctor
    {
        Descricao = descricao;        
    }
}

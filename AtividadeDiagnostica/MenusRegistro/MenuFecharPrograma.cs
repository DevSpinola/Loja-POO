using AtividadeDiagnostica.Modelos;
using AtividadeDiagnostica.Registro;

namespace AtividadeDiagnostica.MenusRegistro;

internal class MenuFecharPrograma : MenuRegistro
{
    public override Cliente Executar(List<Cliente> clientesRegistrados, Cliente clienteAtual)
    {       
       Console.WriteLine("Fechando programa, até a próxima!");   
        Thread.Sleep(2000);
       return base.Executar(clientesRegistrados, clienteAtual);
    }

}

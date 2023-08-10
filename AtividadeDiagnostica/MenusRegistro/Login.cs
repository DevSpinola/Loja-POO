using AtividadeDiagnostica.Modelos;
namespace AtividadeDiagnostica.Registro;

internal class Login : MenuRegistro
{
    public override Cliente? Executar(List<Cliente> clientesRegistrados, Cliente clienteAtual)
    {
        base.Executar(clientesRegistrados, clienteAtual);
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite sua senha:");
        string senha = "";     
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);

            // Verifica se a tecla pressionada é diferente da tecla "Enter"
            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
            {
                senha += key.KeyChar;
                
                Console.Write('*');
            }

        } while (key.Key != ConsoleKey.Enter);// encerra o laco se o usuario apertar enter    

        if (clientesRegistrados.Any(a => a.Nome.Equals(nome) && a.Senha.Equals(senha)))
        {
            clienteAtual = clientesRegistrados.First(a => a.Nome.Equals(nome) && a.Senha.Equals(senha));
            clienteAtual.Logado = true;
            return  clienteAtual;
        }
        else
        {
            Console.WriteLine("Usuário ou senha não correspondem");
            return clienteAtual;
        }
    }
}

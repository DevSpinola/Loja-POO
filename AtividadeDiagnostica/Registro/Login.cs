using AtividadeDiagnostica.Modelos;
namespace AtividadeDiagnostica.Registro;

internal class Login : MenuRegistro
{
    public override void Executar(List<Cliente> clientesRegistrados)
    {
        base.Executar(clientesRegistrados);
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite sua senha:");
        string senha = "";
        string senhaCensurada = "";
        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true);

            // Verifica se a tecla pressionada é diferente da tecla "Enter"
            if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
            {
                senha += key.KeyChar;
                senhaCensurada += '*';
                Console.Write(senhaCensurada);
            }
            else if(key.Key == ConsoleKey.Backspace)
            {
                senha = senha.Substring(senha.Length - 1);
                senhaCensurada = senhaCensurada.Substring(senha.Length - 1);
                Console.Write(senhaCensurada);
            }
           
        } while (key.Key != ConsoleKey.Enter);// encerra o laco se o usuario apertar enter    

        if (clientesRegistrados.Any(a => a.Nome.Equals(nome) && a.Senha.Equals(senha)))
        {
            Cliente clienteEncontrado = clientesRegistrados.First(a => a.Nome.Equals(nome) && a.Senha.Equals(senha));
            clienteEncontrado.logado = true;
        }
        else
        {
            Console.WriteLine("Usuário não encontrado");
        }
    }
}

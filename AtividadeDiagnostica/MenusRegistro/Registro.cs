using AtividadeDiagnostica.Modelos;
namespace AtividadeDiagnostica.Registro;

internal class Registro : MenuRegistro
{
    public override Cliente Executar(List<Cliente> clientesRegistrados, Cliente clienteAtual)
    {
        base.Executar(clientesRegistrados, clienteAtual);
        Console.WriteLine("Para utilizar nossos serviços primeiro registre-se");
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine()!;
        Console.Write("Digite seu CPF:");
        string cpf = Console.ReadLine()!;
        string senha1, senha2; // 2 Variaveis de senha para fazer a confirmacao

        do // este laco faz com que a senha digita nao apareca na tela
        {
            Console.WriteLine("Digite sua senha:");
            string senhaTemp = "";           
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                // Verifica se a tecla pressionada é diferente da tecla "Enter"
                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    senhaTemp += key.KeyChar;                    
                    Console.Write('*');
                }


            } while (key.Key != ConsoleKey.Enter);// encerra o laco se o usuario apertar enter

            senha1 = senhaTemp;

            Console.WriteLine();
            Console.WriteLine("Confirme sua senha:"); // Faz a mesma coisa para poder confirmar a senha
            senhaTemp = "";         

            do
            {
                key = Console.ReadKey(true);

                // Verifica se a tecla pressionada é diferente da tecla "Enter"
                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace)
                {
                    senhaTemp += key.KeyChar;                   
                    Console.Write('*');
                }
            } while (key.Key != ConsoleKey.Enter);

            senha2 = senhaTemp;
            Console.WriteLine();

            // Verifica se as senhas sao iguais
            if (senha1 != senha2)
            {
                Console.WriteLine("As senhas nao correspondem, digite novamente");
            }

        } while (senha1 != senha2); // Se a senha nao bater refaz o laco

        Console.WriteLine("Senha cadastrada com sucesso");
        Thread.Sleep(1500); // Espera 1,5 segundos antes de continuar a execução
        Console.Clear(); // Limpa a tela do console
        clienteAtual = new Cliente(nome, cpf, senha1)
        {
            Logado = true
        };
        clientesRegistrados.Add(clienteAtual);
        return clienteAtual;

    }
}

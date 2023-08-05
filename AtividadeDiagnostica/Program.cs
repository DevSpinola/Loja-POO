using AtividadeDiagnostica.Modelos;

Dictionary<int, Produto> listaProdutos = new()
{
    {1, new Produto("Arroz")},
    {2, new Produto("Feijão")},
    {3, new Produto("Ovo")},
    {4, new Produto("Batata Doce")},
    {5, new Produto("Alface")},
    {6, new Produto("Tomate")},
    {7, new Produto("Whey Protein")},
    {8, new Produto("Bife")},
    {9, new Produto("Suco")},
    {10, new Produto("Água")},
    {11, new Produto("Salmão")},
    {12, new Produto("Frango")},
    {13, new Produto("Macarrão")},
    {14, new Produto("Aveia")}
};
List<Cliente> clientesRegistrados = new();
bool logado = false;


void ExibirBoasVindas(string nome)
{
    Console.WriteLine($"Bem vindo à loja {nome}!");
}
void ExibirTelaDeRegistro()
{
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
            if (key.Key != ConsoleKey.Enter)
            {
                senhaTemp += key.KeyChar;
                Console.Write("*");
            }

        } while (key.Key != ConsoleKey.Enter);// encerra o laco se o usuario apertar enter

        senha1 = senhaTemp;

        Console.WriteLine();
        Console.WriteLine("Confirme sua senha:"); // Faz a mesma coisa para poder confirmar a senha
        senhaTemp = "";

        do
        {
            key = Console.ReadKey(true);


            if (key.Key != ConsoleKey.Enter)
            {
                senhaTemp += key.KeyChar;
                Console.Write("*");
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
    clientesRegistrados.Add(new(nome, cpf, senha1));
    ExibirBoasVindas(nome);
    logado = true;
}
void ExibirTelaDeLogin()
{
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
            Console.Write("*");
        }
        /*else if(key.Key == ConsoleKey.Backspace)
        {
            senha = senha.Substring(senha.Length - 1);
            Console.Write() 
        }
        */
    } while (key.Key != ConsoleKey.Enter);// encerra o laco se o usuario apertar enter    

    if (clientesRegistrados.Any(a => a.Nome.Equals(nome) && a.Senha.Equals(senha)))
    {
        ExibirBoasVindas(nome);
        logado = true;
    }
    else
    {
        Console.WriteLine("Usuário não encontrado");
    }
}
void ExibirAbaRegistro()
{
    Console.WriteLine("Bem vindo à loja, para utilizar nossos serviços primeiro registre-se");
    Console.WriteLine("Digite 1 para se registrar, caso já tenha cadastro digite 2");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            ExibirTelaDeRegistro();
            break;
        case 2:
            ExibirTelaDeLogin();
            break;
        default:
            Console.WriteLine("Opcao Inválida");
            break;
    }
    if (logado)
    {
        //  ExibirMenu();
    }
    else
    {
        ExibirAbaRegistro();
    }
}
ExibirAbaRegistro();




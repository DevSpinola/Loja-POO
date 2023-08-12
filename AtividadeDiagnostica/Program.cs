using AtividadeDiagnostica.Modelos;
using AtividadeDiagnostica.Menus;
using AtividadeDiagnostica.Registro;

// Cria um dicionário de produtos com códigos como chave e objetos Produto como valor
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

// Cria uma lista vazia de objetos Cliente
List<Cliente> clientesRegistrados = new();
Cliente? clienteAtual = null; // Variável para armazenar o cliente atual

// Cria um dicionário de opções de menu que armazenam os codigos em formato de classe
Dictionary<int, Menu> opcoesLoja = new()
{
    { 1, new MenuAdicionarAoCarrinho() },
    { 2, new MenuMostrarCarrinho() },
    { -1, new MenuSair() }
};
Dictionary<int, MenuRegistro> opcoesRegistro = new()
{
    { 1, new Registro() },
    { 2, new Login() },
    
};

// Função para exibir mensagem de boas-vindas
void ExibirBoasVindas(string nome)
{
    Console.Clear();
    Console.WriteLine($"Bem vindo à loja {nome}!");
}

// Função para exibir formulário de registro
void ExibirAbaRegistro()
{
    Console.Clear();
    Console.WriteLine("Bem vindo à loja, para utilizar nossos serviços primeiro registre-se, digite 1 para se registrar");
    Console.WriteLine("Já possuí cadastro? digite 2 para logar");
    int opcaoEscolhida = int.Parse( Console.ReadLine()! );
    if (opcoesRegistro.ContainsKey(opcaoEscolhida))
    {
        MenuRegistro menuAserExibido = opcoesRegistro[opcaoEscolhida];
        clienteAtual = menuAserExibido.Executar(clientesRegistrados, clienteAtual);

        if (clienteAtual is null || clienteAtual.Logado == false )
        {                       
            ExibirAbaRegistro(); // Exibe novamente o menu principal
        }      
        else
        {
            ExibirBoasVindas(clienteAtual.Nome);
            ExibirMenus();
        }
    }
    else
    {
        Console.WriteLine("Opção Inválida"); // Mensagem de opção inválida caso a opção seja negativa
        ExibirAbaRegistro();
    }

}

// Função para exibir opções de menu
void ExibirMenus()
{
    Console.WriteLine("Digite 1 para Adicionar Produtos ao Carrinho");
    Console.WriteLine("Digite 2 para mostrar Produtos do Carrinho");
    Console.WriteLine("Digite -1 para sair do programa");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!); // Lê a opção escolhida pelo usuário

    if (opcoesLoja.ContainsKey(opcaoEscolhida))// Se a opcao escolhida estiver dentro do Dicionário
    {
        Menu menuASerExibido = opcoesLoja[opcaoEscolhida]; // Obtém o menu correspondente à opção escolhida
        menuASerExibido.Executar(listaProdutos, clienteAtual); // Executa o menu com a lista de produtos e o cliente atual

        if (opcaoEscolhida > 0)
        {
            ExibirMenus(); // Exibe novamente o menu principal
        }
        else if (opcaoEscolhida == -1)
        {
            ExibirAbaRegistro();
        }
        else
        {
            Console.WriteLine("Opção Inválida"); // Mensagem de opção inválida caso a opção seja negativa
        }
    }
}
ExibirAbaRegistro(); // Exibe o formulário de registro



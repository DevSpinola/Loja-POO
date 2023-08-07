using AtividadeDiagnostica.Modelos;
using AtividadeDiagnostica.Menus;

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
Cliente clienteAtual;

Dictionary<int, Menu> opcoesLoja = new()
{
    { 1, new MenuAdicionarAoCarrinho() },
    { 2, new MenuMostrarCarrinho() },
    { -1, new MenuSair() }
};


void ExibirBoasVindas(string nome)
{
    Console.Clear();
    Console.WriteLine($"Bem vindo à loja {nome}!");
}
void ExibirAbaRegistro()
{
    Console.Clear();
    Console.WriteLine("Bem vindo à loja, para utilizar nossos serviços primeiro registre-se");
    Console.WriteLine("Digite seu nome");
    string nome = Console.ReadLine()!;
    Console.WriteLine("Digite seu CPF");
    string cpf = Console.ReadLine()!;
    Console.WriteLine("Digite sua senha");
    string senha = Console.ReadLine()!;
    clienteAtual = new Cliente(nome, cpf, senha);
    clientesRegistrados.Add(clienteAtual);
}
void ExibirMenus()
{    
    Console.WriteLine("Digite 1 para Adicionar Produtos ao Carrinho");
    Console.WriteLine("Digite 2 para mostrar Produtos do Carrinho");
    Console.WriteLine("Digite -1 para sair do programa");
    int opcaoescolhida = int.Parse(Console.ReadLine()!);
    if (opcoesLoja.ContainsKey(opcaoescolhida))
    {
        Menu menuAserExibido = opcoesLoja[opcaoescolhida];
        menuAserExibido.Executar(listaProdutos, clienteAtual);
        if(opcaoescolhida> 0)
        {
            ExibirMenus();
        }
        else
        {
            Console.WriteLine("Opção Inválida");
        }
    }
}
ExibirAbaRegistro();
ExibirBoasVindas(clienteAtual.Nome);
ExibirMenus();





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
    Console.Write("Digite sua senha");
    string senha = Console.ReadLine()!;
    clientesRegistrados.Add(new(nome, cpf, senha));
    ExibirBoasVindas(nome);
    logado= true;
}
void ExibirTelaDeLogin()
{
    Console.Write("Digite seu nome:");
    string nome = Console.ReadLine()!;
    Console.Write("Digite sua senha");
    string senha = Console.ReadLine()!;
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


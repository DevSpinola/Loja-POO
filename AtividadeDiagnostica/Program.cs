using AtividadeDiagnostica.Modelos;
using AtividadeDiagnostica.Registro;

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

Dictionary<int, MenuRegistro> opcoesRegistro = new()
{
    {1, new Registro() },
    {2, new Login() }
};


void ExibirBoasVindas(string nome)
{
    Console.WriteLine($"Bem vindo à loja {nome}!");
}
void ExibirAbaRegistro()
{
    Console.Clear();
    Console.WriteLine("Bem vindo à loja, para utilizar nossos serviços primeiro registre-se");
    Console.WriteLine("Digite 1 para se registrar, caso já tenha cadastro digite 2");
    int opcao = int.Parse(Console.ReadLine()!);
    if (opcoesRegistro.ContainsKey(opcao))
    {
        MenuRegistro menuASerExibido = opcoesRegistro[opcao];
        menuASerExibido.Executar(clientesRegistrados);
    }   
    else
    {
        Console.WriteLine("Opção Inválida");
        ExibirAbaRegistro();
    }
}
ExibirAbaRegistro();




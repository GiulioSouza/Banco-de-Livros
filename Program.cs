using Cadastros.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

DateTime horaAtual = DateTime.Now;

if(horaAtual.Hour < 12 && horaAtual.Hour > 5)
{
    Console.WriteLine("Bom Dia!");
}
else if(horaAtual.Hour < 18)
{
    Console.WriteLine("Boa Tarde!");
}
else
{
    Console.WriteLine("Boa Noite!");
}

Console.WriteLine("Seja bem vindo ao seu banco de livros! \n" + 
                "Digite seu nome:");
string nomeDigitado = Console.ReadLine();

Console.WriteLine("Agora digite um código que só tenha números: ");
int codigoDigitado = Convert.ToInt32((Console.ReadLine()));

Pessoa novaPessoa = new Pessoa(nome: nomeDigitado, codigo: codigoDigitado);

bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Adicionar livro");
    Console.WriteLine("2 - Remover livro");
    Console.WriteLine("3 - Listar livros");
    Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine())
    {
        case "1":
            try
            {
                Console.WriteLine(novaPessoa.AdicionarLivro());
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("A ação não pôde ser concluida.");
                break;
            }

        case "2":
            try
            {
                Console.WriteLine(novaPessoa.RemoverLivro());
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("A ação não pôde ser concluida.");
                break;
            }

        case "3":
            try
            {
                novaPessoa.ListarLivros();
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("A ação não pôde ser concluida.");
                break;
            }

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou, volte sempre!");
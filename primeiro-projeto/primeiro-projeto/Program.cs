// Screen Sound
using System.Data;
using System.Runtime.CompilerServices;


string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("Teh Beatles", new List<int>());


void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine($"Você escolheu a opção = {opcaoEscolhidaNumerica}");
            break;
        case -1:
            Console.WriteLine("Até logo! :)");
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();//LIMPA O TERMINAL
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000); //DELAY DE EXBIÇÃO 
    Console.Clear(); //LIMPA O TERMINAL
    ExibirOpcoesDoMenu(); //EXIBE AS OPÇÕES DO MENU
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    foreach (string banda in bandasRegistradas.Keys)
    {
      Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dictionary >> atribuir uma nota
    //senão volta ao menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota da banda {nomeDaBanda}");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("A nota para foi registrada com sucesso");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite um tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }


}

ExibirLogo();
ExibirOpcoesDoMenu();
 
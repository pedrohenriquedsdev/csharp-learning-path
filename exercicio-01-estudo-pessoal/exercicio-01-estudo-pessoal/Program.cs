using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Numerics;

/// NÍVEL 1 - FUNDAÇÕES(Conceitos básicos)
//Exercício 1: Calculadora de Saudação
//Crie um programa que:

//Use Console.Write para perguntar o nome do usuário

//Use Console.ReadLine para capturar o nome

//Armazene em uma variável string

//Use Console.WriteLine para exibir "Olá, [nome]! Seja bem-vindo!"

//csharp
//// Exemplo de saída:
//// Digite seu nome: João
//// Olá, João! Seja bem-vindo!
//Exercício 2: Verificador de Idade
//Peça ao usuário para digitar a idade (use int)

//Use if/else para verificar:

//Se idade >= 18: "Você é maior de idade"

//Se idade< 18: "Você é menor de idade"

//Use Console.Clear para limpar a tela antes de mostrar o resultado

//Exercício 3: Calculadora de Operações Básicas
//Peça dois números inteiros

//Peça a operação desejada (+, -, *, /)

//Use switch para executar a operação correta

//Mostre o resultado usando Console.WriteLine


Console.WriteLine("Bem vindo ao 'Tarefas por Etapa'\n");


Console.Write("1 - Digite o seu nome: ");
string nome = Console.ReadLine()!;
Console.Clear();
Console.WriteLine($"Olá {nome}, sejá bem-vindo!\n");



Console.Write("2 - Digite a sua idade: ");
string idade = Console.ReadLine()!;
int idadeNumero = int.Parse(idade);

if (idadeNumero >= 18)
{
    Console.WriteLine($"Sua idade '{idadeNumero} anos' te faz uma pessoa maior de idade");
}
else
{
    Console.WriteLine($"\nSua idade '{idadeNumero} anos' te faz uma pessoa menor de idade");
}

Thread.Sleep(2500);
Console.Clear();

Console.WriteLine("Bem vindo a calculadora de Operações!");
Console.WriteLine("************************************");
    ;
Console.Write("\nDigite o primeiro número: ");
string primeiroNumero = Console.ReadLine()!;
double primeiroNumeroDouble = double.Parse(primeiroNumero);

Console.Write("Escolha uma das seguints operações -> (+, -, *, /): ");
string operacao = Console.ReadLine()!;

Console.Write("Digite o segundo número: ");
string segundoNumero = Console.ReadLine()!;
double segundoNumeroDouble = double.Parse(segundoNumero);


switch (operacao)
{
    case "+":
        double totalSoma = primeiroNumeroDouble + segundoNumeroDouble;
        Console.WriteLine($"= {totalSoma}");
        break;

    case "-":
        double totalSub = primeiroNumeroDouble - segundoNumeroDouble;
        Console.WriteLine($"= {totalSub}");
        break;

    case "*":
        double totalMult = primeiroNumeroDouble * segundoNumeroDouble;
        Console.WriteLine($"= {totalMult}");
        break;

    case "/":
        double totalDiv = primeiroNumeroDouble / segundoNumeroDouble;
        Console.WriteLine($"= {totalDiv}");
        break;

    default:
        Console.WriteLine("Operação Inválida. Por favor, digite uma das existentes.");
        break;

}

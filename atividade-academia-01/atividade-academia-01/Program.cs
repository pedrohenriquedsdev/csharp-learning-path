// O programa recebe três valores (X, Y, Z) que representam os lados de um triângulo e classifica o triângulo como
// equilátero, isósceles ou escaleno. Caso os valores não formem um triângulo válido, o programa informa que o
// triângulo é inválido. O usuário pode verificar vários triângulos em sequência através de um menu de opções.

// Regras e Funcionalidades:

// 1.Entrada de Dados:
// ○ O programa solicita ao usuário três valores (X, Y, Z) que representam os lados de um triângulo.

// 2. Classificação do Triângulo:
// ○ O programa verifica se os valores formam um triângulo válido, seguindo a condição de existência:
// ■ A soma de quaisquer dois lados deve ser maior que o terceiro lado.
// ○ Se os valores formarem um triângulo válido, o programa classifica o triângulo em:
// ■ Equilátero: Todos os lados iguais.
// ■ Isósceles: Dois lados iguais.
// ■ Escaleno: Todos os lados diferentes.
// ○ Caso contrário, o programa informa que o triângulo é inválido.

// 3. Menu de Opções:
// ○ O programa exibe um menu que permite ao usuário:
// ■ Verificar um novo triângulo.
// ■ Sair do programa.
// Dificuldades e Conceitos Envolvidos:
// ● Condicionais: Para verificar a validade do triângulo e sua classificação.
// ● Loops: Para permitir que o usuário verifique vários triângulos sem sair do programa.
// ● Validação de entrada: Para garantir que os valores inseridos sejam positivos e válidos.
// ● Menu interativo: Para oferecer uma experiência de usuário amigável.

using System.ComponentModel;

MenuDeOpcoes();
ExecutandoPorOpcaoEscolhida();

void MenuDeOpcoes()
{
    Console.WriteLine("**************");
    Console.WriteLine("MENU DE OPÇÕES");
    Console.WriteLine("**************\n");

    Console.WriteLine("1 - Verificar um novo Triângulo");
    Console.WriteLine("2 - Sair do Programa\n");
}

void ExecutandoPorOpcaoEscolhida()
{
    Console.Write("Selecione uma das opcões acima: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumero)
    {
        case 1:
            Console.Clear();
            Console.Write("Insira o valor de X: ");
            string valorDeX = Console.ReadLine()!;
            int valorDeXNumerico = int.Parse(valorDeX);

            Console.Write("Insira o valor de Y: ");
            string valorDeY = Console.ReadLine()!;
            int valorDeYNumerico = int.Parse(valorDeY);

            Console.Write("Insira o valor de Z: ");
            string valorDeZ = Console.ReadLine()!;
            int valorDeZNumerico = int.Parse(valorDeZ);

            if (valorDeXNumerico > 0 && valorDeYNumerico > 0 && valorDeZNumerico > 0
            && valorDeXNumerico + valorDeYNumerico > valorDeZNumerico
            && valorDeXNumerico + valorDeZNumerico > valorDeYNumerico
            && valorDeZNumerico + valorDeYNumerico > valorDeXNumerico)
            {
                Console.WriteLine("Triângulo Válido!");

                if (valorDeXNumerico == valorDeYNumerico && valorDeXNumerico == valorDeZNumerico)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }

                else if (
                valorDeXNumerico == valorDeYNumerico //&& valorDeXNumerico != valorDeZNumerico
                || valorDeXNumerico == valorDeZNumerico //&& valorDeXNumerico != valorDeYNumerico
                || valorDeYNumerico == valorDeZNumerico //&& valorDeYNumerico != valorDeXNumerico
                )
                {
                    Console.WriteLine("Triângulo Isósceles");
                }

                else if (valorDeXNumerico != valorDeYNumerico && valorDeXNumerico != valorDeZNumerico && valorDeYNumerico != valorDeZNumerico)
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Triângulo Inválido!");
            }
            Thread.Sleep(2000);
            Console.Clear();
            MenuDeOpcoes();
            ExecutandoPorOpcaoEscolhida();
            break;


        case 2:
            break;


        default:
            Console.WriteLine("Opção inválida. Por favor, digite uma das opções corretas.");
            Thread.Sleep(2000);
            Console.Clear();
            MenuDeOpcoes();
            ExecutandoPorOpcaoEscolhida();
            break;
    }
}
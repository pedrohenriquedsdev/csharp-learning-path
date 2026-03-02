using System;
using System.ComponentModel.Design;

namespace MeuProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Objetivo do Jogo:
            //O jogador e o computador competem em uma corrida virtual. Cada um rola um dado virtual (geração de números
            //aleatórios) para avançar em uma pista.O primeiro a alcançar ou ultrapassar a linha de chegada vence.
            //Regras e Funcionalidades:

            //    1. Pista:
            //    ○ A pista é representada por uma linha numérica (ex.: de 0 a 30). [X]
            //    ○ O jogador e o computador começam na posição 0.[X]

            //    2. Turnos:
            //    ○ O jogador e o computador alternam turnos para rolar um dado(gerar um número aleatório [X]
            //    entre 1 e 6).
            //    ○ O número gerado é somado à posição atual do competidor. [X]
            //    ○ O jogo exibe a posição atual do jogador e do computador após cada rodada. [X]

            //    3. Eventos Especiais:
            //    ○ Para tornar o jogo mais interessante, algumas posições na pista podem ter eventos especiais: 
            //    ■ Avanço extra: Se o competidor parar em uma posição específica (ex.: 5, 10, 15), ele
            //    avança +3 casas. [X]
            //    ■ Recuo: Se o competidor parar em outra posição específica(ex.: 7, 13, 20), ele recua -2 [X]
            //    casas.
            //    ■ Rodada extra: Se o competidor tirar 6 no dado, ele ganha uma rodada extra. [X]

            //    4. Condição de Vitória:
            //    ○ O primeiro competidor a alcançar ou ultrapassar a posição final (ex.: 30) vence o jogo. [X]
            //    5. Interação:
            //    ○ O jogador rola o dado pressionando uma tecla(ex.: Enter). [X]
            //    ○ O computador rola o dado automaticamente no seu turno. [X]

            //    Dificuldades e Conceitos Envolvidos:
            //    ● Geração de números aleatórios: Para simular o lançamento do dado. [X]
            //    ● Estruturas de repetição: Para controlar os turnos dos competidores. [X]
            //    ● Condicionais: Para verificar eventos especiais e a condição de vitória. [X]
            //    ● Interação com o usuário: Para permitir que o jogador role o dado. [X]
            //    ● Lógica de turnos: Alternar entre o jogador e o computador. [x]


            const int pista = 30;
            int posicaoDoJogador = 0;
            int posicaoDoComputador = 0;
            Random random = new Random();

            while(posicaoDoJogador < pista && posicaoDoComputador < pista)
            {

                Console.Write("APERTE ENTER para rolar os dados");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Rolando Dados...");
                Thread.Sleep(2000);
                

                int dadoDoJogador = random.Next(1, 7);
                posicaoDoJogador += dadoDoJogador;
                Console.WriteLine($"\nDado do JOGADOR: {dadoDoJogador}");

                int dadoDoComputador = random.Next(1, 7);
                posicaoDoComputador += dadoDoComputador;
                Console.WriteLine($"Dado do COMPUTADOR: {dadoDoComputador}\n");

                //AVANCE CASAS 

                if(posicaoDoJogador % 5 == 0)
                {
                    Console.WriteLine($"JOGADOR em posição BÔNUS: {posicaoDoJogador}\n");
                    posicaoDoJogador += 3;
                    Console.WriteLine("Bônus! Posições 5,10,15,20,25 = +3 casas");
                    Console.WriteLine($"Nova posição do JOGADOR: {posicaoDoJogador}\n");
                }
                if(posicaoDoComputador % 5 == 0)
                {
                    Console.WriteLine($"COMPUTADOR em posição BÔNUS: {posicaoDoComputador}\n");
                    posicaoDoComputador += 3;
                    Console.WriteLine("Bônus! Posições 5,10,15,20,25 = +3 casas");
                    Console.WriteLine($"Nova posição do COMPUTADOR: {posicaoDoComputador}\n");
                }

                //RECUE CASAS

                if (posicaoDoJogador % 7 == 0)
                {
                    Console.WriteLine($"JOGADOR em posição ARMADILHA: {posicaoDoJogador}\n");
                    posicaoDoJogador -= 2;
                    Console.WriteLine("QUE AZAR! Posições 7,14,21,28 = -2 casas");
                    Console.WriteLine($"Nova posição do JOGADOR: {posicaoDoJogador}\n");
                }

                if (posicaoDoComputador % 7 == 0)
                {
                    Console.WriteLine($"COMPUTADOR em posição ARMADILHA: {posicaoDoComputador}\n");
                    posicaoDoComputador -= 2;
                    Console.WriteLine("QUE AZAR! Posições 7,14,21,28 = -2 casas");
                    Console.WriteLine($"Nova posição do COMPUTADOR: {posicaoDoComputador}\n");
                }

                

                //DADO = 6? -> Bônus de RODADA EXTRA!

                if (dadoDoJogador == 6)
                {
                    Console.WriteLine("Dado caiu no 6! = RODADA EXTRA para o JOGADOR!\n");
                    Console.Write("APERTE ENTER para rolar os dados\n");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Rolando Dado extra do jogador...");
                    Thread.Sleep(2000);
                    dadoDoJogador = random.Next(1, 7);
                    posicaoDoJogador += dadoDoJogador;
                    Console.WriteLine($"\nDado do JOGADOR: {dadoDoJogador}");
                    Console.Write($"Nova posição após a RODADA EXTRA: {posicaoDoJogador}\n");
                }

                else if (dadoDoComputador == 6)
                {
                    Console.WriteLine("Dado caiu no 6! = RODADA EXTRA para o COMPUTADOR!\n");
                    Console.Write("APERTE ENTER para rolar os dados\n");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Rolando Dado extra do computador...");
                    Thread.Sleep(2000);
                    dadoDoComputador = random.Next(1, 7);
                    posicaoDoComputador += dadoDoComputador;
                    Console.WriteLine($"\nDado do COMPUTADOR: {dadoDoComputador}");
                    Console.Write($"Nova posição após a RODADA EXTRA: {posicaoDoComputador}\n");
                }

                Console.WriteLine($"\nPosições Atuais:\n" +
                    $"Posição do JOGADOR: {posicaoDoJogador}\n" +
                    $"Posição do COMPUTADOR {posicaoDoComputador}\n");


                //Conferindo Vitórias

                int diferencaDePontos = posicaoDoJogador - posicaoDoComputador;


                if (posicaoDoJogador >= 30)
                {
                    Console.Clear();
                    Console.WriteLine("Temos um GRANDE VENCEDOR...");
                    Thread.Sleep(2500);
                    Console.Clear();

                    Console.WriteLine($"Deixando seu oponente para trás com a diferença de '{diferencaDePontos} pontos'");
                    Thread.Sleep(1500);
                    Console.WriteLine("O CAMPEÃO É:");
                    Thread.Sleep(1500);
                    Console.WriteLine("JOGADOR!");

                }

                else if (posicaoDoComputador >= 30)
                {
                    Console.Clear();
                    Console.WriteLine("Temos um GRANDE VENCEDOR...");
                    Thread.Sleep(2500);
                    Console.Clear();

                    Console.WriteLine($"Deixando seu oponente para trás com a diferença de '{diferencaDePontos} pontos'");
                    Thread.Sleep(1500);
                    Console.WriteLine("O CAMPEÃO É:");
                    Thread.Sleep(1500);
                    Console.WriteLine("COMPUTADOR!");

                }

                else if (posicaoDoComputador >= pista && posicaoDoJogador >= pista && posicaoDoJogador == posicaoDoComputador)
                {
                    Console.Clear();
                    Console.WriteLine("Temos um EMPATE!");
                }
            }
            


        }


    }
}
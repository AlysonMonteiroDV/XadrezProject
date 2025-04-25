using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;
using xadrez;
using game_xadrez;
using gtabuleiro;
using game_xadrez.xadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    try
                    {

                        Console.Clear();

                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);



                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                        
                        partida.realizaJogada(origem, destino);

                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }

                Tela.imprimirTabuleiro(partida.tab);



            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}

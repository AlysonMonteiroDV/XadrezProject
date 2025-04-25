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
                    Console.Clear();

                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
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

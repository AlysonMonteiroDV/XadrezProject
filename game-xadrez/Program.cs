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
                Tabuleiro tab = new Tabuleiro(8, 8);


                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 5));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(3, 4));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

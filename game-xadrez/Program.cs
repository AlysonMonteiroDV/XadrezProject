using System;
using System.Globalization;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 9);


            Console.WriteLine(tab);
        }
    }
}

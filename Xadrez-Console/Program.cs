﻿using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('h', 6);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //    Tela.ImprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
        }
    }
}
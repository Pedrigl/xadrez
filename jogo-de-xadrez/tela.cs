using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace jogo_de_xadrez
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else { 
                    Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

    }
}
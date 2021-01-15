using System;
using Tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(tabuleiro tab) // Funcao que imprime o tabuleiro na tela
        {
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++) {

                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.peca(i, j)} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

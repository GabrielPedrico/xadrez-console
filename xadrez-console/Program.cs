﻿using System;
using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            tabuleiro tab = new tabuleiro(8, 8);

            Console.WriteLine($"Tabuleiro: {tab} ");
            Console.ReadLine();
        }
    }
}

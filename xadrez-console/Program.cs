using System;
using System.Runtime.Intrinsics.Arm;
using xadrez_console.tabuleiro;
using xadrez;
using xadrez_console.xadrez;
using tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
           Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();

        }
    }
}

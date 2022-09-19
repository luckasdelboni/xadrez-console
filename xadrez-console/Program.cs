using System;
using System.Runtime.Intrinsics.Arm;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4); 
            Console.WriteLine("Posição " + P);
            Console.ReadLine();
        }
    }
}

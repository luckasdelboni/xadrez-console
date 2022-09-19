using System;
using System.Runtime.Intrinsics.Arm;
using xadrez_console.tabuleiro;
using xadrez;
using xadrez_console.xadrez;
namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre (tab, Cor.Preta),new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei (tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);
            
            Console.ReadLine();
        }
    }
}

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
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab);
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Digite a posição de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Digite a posição de destino: ");
                    Posicao destino= Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            
            
            }


            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}

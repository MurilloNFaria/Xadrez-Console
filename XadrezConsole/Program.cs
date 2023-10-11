using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Verde), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Vermelha), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Amarela), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

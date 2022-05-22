using jogo_de_xadrez;
using tabuleiro;
using Xadrez;

namespace xadrez
{
    class programa
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            tab.colocarpeca(new Torre(Cor.Preta, tab), new Posicao(1, 1));
            tab.colocarpeca(new Rei(Cor.Preta, tab), new Posicao(5,1));
            Console.ReadLine();

        }






    }






}
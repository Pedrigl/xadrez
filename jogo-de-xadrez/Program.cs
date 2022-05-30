using jogo_de_xadrez;
using tabuleiro;
using Xadrez;


namespace xadrez
{
    class programa
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new(8, 8);

            tab.colocarpeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
            tab.colocarpeca(new Rei(Cor.Branca, tab), new Posicao(0, 4));
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }






    }






}
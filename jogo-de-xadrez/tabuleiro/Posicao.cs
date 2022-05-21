namespace tabuleiro
{
    class Posicao
    {
        public int coluna { get; set; }

        public int linha { get; set; }

        public Posicao( int coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString()
        {
            return coluna + ", " + linha;
        }

    }
}

namespace tabuleiro
{
    class Posicao
    {
        public int Coluna { get; set; }

        public int Linha { get; set; }

        public Posicao( int coluna, int linha) {
            this.Coluna = coluna;
            this.Linha = linha;
        }

        public override string ToString()
        {
            return Coluna + ", " + Linha;
        }

    }
}

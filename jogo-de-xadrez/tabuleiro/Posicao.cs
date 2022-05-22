namespace tabuleiro
{
    class Posicao
    {
        public int Coluna { get; set; }

        public int Linha { get; set; }

        public Posicao( int linha, int coluna) {
            Linha = linha;
            Coluna = coluna;
            
        }

        public override string ToString()
        {
            return Coluna + ", " + Linha;
        }

    }
}

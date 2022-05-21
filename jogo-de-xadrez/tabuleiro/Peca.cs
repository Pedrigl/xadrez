﻿using System;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao{ get; set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            QtdMovimentos = 0;
            this.tab = tab;

        }
    }
}
﻿using System;
using tabuleiro;

namespace tabuleiro {
    internal class Peca {
        public Posicao posicao { get; set; }
        public Cor cor {get; protected set;}
        public int quantMovimentos {  get; protected set;}
        public Tabuleiro tabuleiro { get; protected set;}

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro) {
            this.posicao = posicao;
            this.cor = cor;
            quantMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}

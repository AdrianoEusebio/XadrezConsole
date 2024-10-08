﻿using System;
using tabuleiro;

namespace tabuleiro {
     class Peca {
        public Posicao posicao { get; set; }
        public Cor cor {get; protected set;}
        public int quantMovimentos {  get; protected set;}
        public Tabuleiro tabuleiro { get; protected set;}

        public Peca(Cor cor, Tabuleiro tabuleiro) {
            this.posicao = null;
            this.cor = cor;
            quantMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }

        public void incrementarMovimentos() {
            quantMovimentos++;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {
        public char coluna {  get; private set; }
        public int linha { get; set; }

        public PosicaoXadrez(int linha, char coluna) { 
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString() {

            return "" + coluna + linha;
        }
    }
}

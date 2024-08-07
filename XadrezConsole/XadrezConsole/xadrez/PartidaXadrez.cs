using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez {
    class PartidaXadrez {

        public Tabuleiro tab {  get; set; }
        private int turno;
        private Cor playerAtual; 

        public PartidaXadrez() {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.playerAtual = Cor.Branca;
            colocarPecas();

        }

        public void exMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez(1, 'c').toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez(1, 'd').toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez(1, 'e').toPosicao());
           
        }
    }
}

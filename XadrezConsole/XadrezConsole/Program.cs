using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.terminada) { 
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.exMovimento(origem, destino);

                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);            
            }
            
            Console.ReadLine();


            
        }
    }
}
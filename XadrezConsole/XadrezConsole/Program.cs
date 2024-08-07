using System;
using tabuleiro;
using xadrez;

namespace XadrezConsole {
    class Program {
        static void Main(string[] args) {

            try {
                PartidaXadrez partida = new PartidaXadrez();

              
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);            
            }
            
            Console.ReadLine();


            
        }
    }
}

using ProjetoSistemaJogoXadrez;
using tabuleiro;
using Xadrez;



Tabuleiro tab = new Tabuleiro(8, 8);
tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 5));

Tela.ImprimirTabuleiro(tab);
Console.ReadLine();
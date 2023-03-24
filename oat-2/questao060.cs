using System;

/*
Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado 
VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y. 
y 
2o 
Quadrantes 
x | 
1o 
3o 
4o 
*/

public class Program {
  public static int VERIFICA_QUADRANTE(int x, int y) {
    if (x > 0 && y > 0) {
      return 1;
    } else if (x < 0 && y > 0) {
      return 2;
    } else if (x < 0 && y < 0) {
      return 3;
    } else if (x > 0 && y < 0) {
      return 4;
    } else {
      return 0; // coordenadas na origem
    }
  }

  public static void Main() {
    Console.Write("Digite o valor de x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor de y: ");
    int y = int.Parse(Console.ReadLine());

    int quadrante = VERIFICA_QUADRANTE(x, y);

    if (quadrante > 0) {
      Console.WriteLine("O ponto ({0}, {1}) está no quadrante {2}", x, y, quadrante);
    } else if (quadrante == 0) {
      Console.WriteLine("O ponto ({0}, {1}) está na origem", x, y);
    } else {
      Console.WriteLine("Erro: as coordenadas não podem ser iguais a zero simultaneamente.");
    }
  }
}
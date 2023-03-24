using System;

/*
Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os
em ordem decrescente.
*/

public class Program {
  public static void Main() {
    // Lendo os três valores inteiros
    Console.Write("Digite o primeiro valor: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo valor: ");
    int b = int.Parse(Console.ReadLine());

    Console.Write("Digite o terceiro valor: ");
    int c = int.Parse(Console.ReadLine());

    // Ordenando os valores em ordem decrescente
    if (a > b) {
      int temp = a;
      a = b;
      b = temp;
    }

    if (b > c) {
      int temp = b;
      b = c;
      c = temp;
    }

    if (a > b) {
      int temp = a;
      a = b;
      b = temp;
    }

    // Imprimindo os valores em ordem decrescente
    Console.WriteLine("Valores em ordem decrescente: " + c + ", " + b + ", " + a);
  }
}

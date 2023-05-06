using System;

/*
1) Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de
A + B é menor que C.
*/

public class Program {
  public static void Main() {
    // Lendo os valores de A, B e C
    Console.Write("Digite o valor de A: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor de B: ");
    int b = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor de C: ");
    int c = int.Parse(Console.ReadLine());

    // Verificando se a soma de A e B é menor do que C
    if (a + b < c) {
      Console.WriteLine("A soma de A e B é menor do que C.");
    } else {
      Console.WriteLine("A soma de A e B é maior ou igual a C.");
    }
  }
}
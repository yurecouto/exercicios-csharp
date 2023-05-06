using System;

/*
Faça um algoritmo que leia uma variável e some 5, caso seja par ou some 8,
caso seja ímpar, imprimir o resultado desta operação.
*/

public class Program {
  public static void Main() {
    // Lendo o valor da variável
    Console.Write("Digite o valor da variável: ");
    int variavel = int.Parse(Console.ReadLine());

    // Verificando se a variável é par ou ímpar
    if (variavel % 2 == 0) {
      // Se for par, soma 5
      variavel += 5;
    } else {
      // Se for ímpar, soma 8
      variavel += 8;
    }

    // Imprimindo o resultado
    Console.WriteLine("Resultado: " + variavel);
  }
}

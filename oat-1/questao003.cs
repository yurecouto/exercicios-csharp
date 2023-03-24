using System;

/*
Faça um algoritmo para receber um número qualquer e informar na tela se é
par ou ímpar.
*/

public class Program {
  public static void Main() {
    // Lendo o número do usuário
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    // Verificando se o número é par ou ímpar
    if (numero % 2 == 0) {
      Console.WriteLine("O número {0} é par.", numero);
    } else {
      Console.WriteLine("O número {0} é ímpar.", numero);
    }
  }
}

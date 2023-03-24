using System;

/*
Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor 
fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, 
apresentar a mensagem "valor válido". Caso contrário, apresentar a mensagem "valor inválido". 
*/

public class Program {
  public static void Main() {
    Console.WriteLine("Digite um número inteiro: ");
    int num = int.Parse(Console.ReadLine());

    if(num >= 0 && num <= 9) {
      Console.WriteLine("Valor válido.");
    }
    else {
      Console.WriteLine("Valor inválido.");
    }
  }
}
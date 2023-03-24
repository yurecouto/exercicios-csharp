using System;

/*
Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente entre eles. 
Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir mensagem de erro. 
Exemplo: Digite 2 caracteres: jt O numero de caracteres entre eles é: 9 
*/

public class Program {
  public static void Main() {
    Console.Write("Digite 2 caracteres (em ordem alfabética): ");
    string entrada = Console.ReadLine();

    if (entrada.Length != 2 || entrada[0] >= entrada[1]) {
      Console.WriteLine("Erro: caracteres inválidos.");
      return;
    }

    int numeroDeCaracteres = entrada[1] - entrada[0] - 1;

    Console.WriteLine("O número de caracteres entre os dois é: " + numeroDeCaracteres);
  }
}
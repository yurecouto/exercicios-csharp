using System;

/*
Escreva um algoritmo que lê dois valores booleanos (lógicos) e então
determina se ambos são VERDADEIROS ou FALSOS.
*/

public class Program {
  public static void Main() {
    // Lendo os valores booleanos do usuário
    Console.Write("Digite o primeiro valor booleano (true/false): ");
    bool valor1 = bool.Parse(Console.ReadLine());
    Console.Write("Digite o segundo valor booleano (true/false): ");
    bool valor2 = bool.Parse(Console.ReadLine());

    // Verificando se ambos os valores são verdadeiros ou falsos
    if (valor1 && valor2) {
      Console.WriteLine("Ambos os valores são VERDADEIROS");
    } else if (!valor1 && !valor2) {
      Console.WriteLine("Ambos os valores são FALSOS");
    } else {
      Console.WriteLine("Os valores são diferentes");
    }
  }
}
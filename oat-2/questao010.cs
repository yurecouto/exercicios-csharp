using System;

/*
Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes 
entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 
*/

public class Program {
  public static void Main() {
    int num1, num2;

    Console.Write("Digite o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    num2 = int.Parse(Console.ReadLine());

    if (num1 == num2) {
      Console.WriteLine("Igual");
    }
    else {
      Console.WriteLine("Não igual");
      if (num1 > num2) {
        Console.WriteLine("Maior");
        Console.WriteLine("Maior ou igual");
        Console.WriteLine("Menor");
        Console.WriteLine("Menor ou igual");
      }
      else {
        Console.WriteLine("Menor");
        Console.WriteLine("Menor ou igual");
        Console.WriteLine("Maior");
        Console.WriteLine("Maior ou igual");
      }
    }
  }
}
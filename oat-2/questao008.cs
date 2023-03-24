using System;

/*
Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula: de calculo de volume
*/

public class Program {
  public static void Main() {
    double pi = 3.14159;
    double r, h, v;

    Console.Write("Digite o raio da base da lata de óleo: ");
    r = double.Parse(Console.ReadLine());

    Console.Write("Digite a altura da lata de óleo: ");
    h = double.Parse(Console.ReadLine());

    v = pi * Math.Pow(r, 2) * h;

    Console.WriteLine("O volume da lata de óleo é: " + v.ToString("F2"));
  }
}

using System;

/*
Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius. 
A fórmula de conversão de temperatura a ser utilizada é C = (F - 32) * 5/9, em que a variável 
F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius. 
*/

public class Program {
  public static void Main() {
    double f, c;
    Console.Write("Digite a temperatura em graus Fahrenheit: ");
    f = double.Parse(Console.ReadLine());
    c = (f - 32) * 5/9;
    Console.WriteLine("A temperatura em graus Celsius é: " + c);
  }
}
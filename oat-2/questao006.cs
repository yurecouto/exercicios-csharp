using System;

/*
Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula de conversão de temperatura a ser utilizada é F = (9* C + 160) / 5, em que a 
variável F representa é a temperatura em graus Fahrenheit e a variável C representa 
é a temperatura em graus Celsius.
*/

public class Program {
    public static void Main() {
        double celsius, fahrenheit;

        Console.Write("Digite a temperatura em Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = (9 * celsius + 160) / 5;

        Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit.ToString("F1"));
    }
}
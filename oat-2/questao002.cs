using System;

/*
Faça um programa que: 
- Leia a cotação do dólar 
- 
Leia um valor em dólares 
Converta esse valor para Real 
Mostre o resultado 
*/

public class Program 
{
    public static void Main() 
    {
        Console.Write("Digite a cotação do dólar: ");
        double cotacao = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor em dólares: ");
        double valorDolar = double.Parse(Console.ReadLine());

        double valorReal = valorDolar * cotacao;

        Console.WriteLine("O valor em reais é: " + valorReal);
    }
}

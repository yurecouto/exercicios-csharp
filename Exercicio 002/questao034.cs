using System;

/*
Escreva um programa que leia um conjunto de números positivos e exiba o menor e o maior. 
Suporemos que o número de elementos deste conjunto não é conhecido, e que um número negativo 
será utilizado para sinalizar o fim dos dados. 
*/

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite uma sequência de números positivos (para encerrar, digite um número negativo):");

        int numero = 0;
        int menor = int.MaxValue;
        int maior = int.MinValue;

        while (true)
        {
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                break;

            if (numero < menor)
                menor = numero;

            if (numero > maior)
                maior = numero;
        }

        Console.WriteLine($"Menor número: {menor}");
        Console.WriteLine($"Maior número: {maior}");
    }
}
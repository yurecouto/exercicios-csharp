using System;

/*
Faça um programa para calcular o estoque médio de uma peça, sendo que: 
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE MÁXIMA) / 2. 
*/

public class Program
{
    public static void Main()
    {
        // Leitura das quantidades mínima e máxima
        Console.Write("Digite a quantidade mínima: ");
        int qtdMinima = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade máxima: ");
        int qtdMaxima = int.Parse(Console.ReadLine());

        // Cálculo do estoque médio
        double estoqueMedio = (qtdMinima + qtdMaxima) / 2.0;

        // Exibição do resultado
        Console.WriteLine($"O estoque médio é: {estoqueMedio}");
    }
}

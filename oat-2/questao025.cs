using System;

/*
Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um programa que calcule seu peso ideal, 
utilizando as seguintes fórmulas: (h = altura) 
Para homens: (72.7*h) - 58 
Para mulheres: (62.1 *h) - 44.7 
*/

public class Program {
    public static void Main() {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M ou F): ");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        double pesoIdeal;

        if (sexo == 'M') {
            pesoIdeal = (72.7 * altura) - 58;
        } else if (sexo == 'F') {
            pesoIdeal = (62.1 * altura) - 44.7;
        } else {
            Console.WriteLine("Sexo inválido.");
            return;
        }

        Console.WriteLine($"O peso ideal para uma pessoa com altura {altura}m e sexo {sexo} é {pesoIdeal:F2}kg.");
    }
}
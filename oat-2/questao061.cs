using System;

/*
Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve 
receber o valor do salário e o índice de reajuste. 
*/

public class Program
{
    public static double REAJUSTE(double salario, double indice)
    {
        double novoSalario = salario * (1 + indice / 100);
        return novoSalario;
    }

    public static void Main()
    {
        Console.Write("Digite o valor do salário atual: ");
        double salarioAtual = double.Parse(Console.ReadLine());

        Console.Write("Digite o índice de reajuste (em %): ");
        double indiceReajuste = double.Parse(Console.ReadLine());

        double novoSalario = REAJUSTE(salarioAtual, indiceReajuste);

        Console.WriteLine("O novo salário é R$ {0:F2}", novoSalario);
    }
}
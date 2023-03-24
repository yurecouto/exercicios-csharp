using System;

/*
Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método 
recebe o valor da base e da altura de um triângulo. 
Fórmulas: hipotenusa2 = base2+ altura2 
área 
= 
base x altura 
2 
*/

public class Program
{
    public static void Main()
    {
        double baseTriangulo, alturaTriangulo;
        Console.Write("Digite o valor da base do triângulo: ");
        baseTriangulo = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor da altura do triângulo: ");
        alturaTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine($"A hipotenusa do triângulo é {Hipotenusa(baseTriangulo, alturaTriangulo):F2}");
    }

    public static double Hipotenusa(double baseTriangulo, double alturaTriangulo)
    {
        double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        return hipotenusa;
    }
}
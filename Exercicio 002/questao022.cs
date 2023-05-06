using System;

// Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o resultado.

public class Program {
    public static void Main() {
        int num, a = 0, b = 0;
        Console.Write("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        if (num > 0) {
            a = num;
        }
        else {
            b = num;
        }
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
    }
}

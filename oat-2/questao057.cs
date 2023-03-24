using System;

/*Fazer um programa que leia uma frase e imprima somente as vogais.*/

public class Program {
    public static void Main() {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
        string vogais = "aeiouAEIOU"; // string com todas as vogais
        
        Console.WriteLine("Vogais na frase:");
        foreach(char letra in frase) {
            if (vogais.Contains(letra)) {
                Console.Write(letra);
            }
        }
    }
}
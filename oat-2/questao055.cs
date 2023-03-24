using System;

/*
Fazer um programa que leia uma frase de até 50 caracteres e imprima a frase sem os espaços em branco. 
Imprimir também a quantidade de espaços em branco da frase. 
*/


public class Program {
    public static void Main() {
        Console.Write("Digite uma frase (até 50 caracteres): ");
        string frase = Console.ReadLine();
        
        // Remover espaços em branco
        string fraseSemEspacos = frase.Replace(" ", "");
        
        // Calcular quantidade de espaços em branco
        int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;
        
        Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
        Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);
    }
}

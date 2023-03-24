using System;

/*
Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.
*/

public class Program {
    public static void Main() {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] vetor = new int[n];
        
        for (int i = 0; i < n; i++) {
            Console.Write($"Digite o {i + 1}° número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("Sequência na ordem inversa:");
        
        for (int i = n - 1; i >= 0; i--) {
            Console.Write(vetor[i] + " ");
        }
        
        Console.ReadKey();
    }
}
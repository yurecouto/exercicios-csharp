using System;

/*
Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes 
que V1 e V2 possuem valores idênticos nas mesmas posições.
*/

public class Program {
    public static void Main() {
        const int MAX = 50; // Tamanho máximo dos vetores
        int[] v1 = new int[MAX];
        int[] v2 = new int[MAX];
        int n, i, count = 0;
        
        Console.Write("Digite o tamanho dos vetores (no máximo 50): ");
        n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite os elementos do vetor V1:");
        for (i = 0; i < n; i++) {
            Console.Write("V1[" + i + "]: ");
            v1[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nDigite os elementos do vetor V2:");
        for (i = 0; i < n; i++) {
            Console.Write("V2[" + i + "]: ");
            v2[i] = int.Parse(Console.ReadLine());
        }
        
        // Verifica quantas vezes os vetores possuem valores iguais nas mesmas posições
        for (i = 0; i < n; i++) {
            if (v1[i] == v2[i]) {
                count++;
            }
        }
        
        Console.WriteLine("\nNúmero de valores idênticos nas mesmas posições: " + count);
    }
}
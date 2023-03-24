using System;

/*
Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em C que imprima todos os elementos 
comuns aos dois vetores. 
*/

public class Program {
  public static void Main() {
    int[] A = {1, 2, 3, 4, 5};
    int[] B = {4, 5, 6, 7, 8, 9, 10, 11};
    
    // Percorrendo os elementos do vetor A
    for(int i = 0; i < A.Length; i++) {
      // Percorrendo os elementos do vetor B
      for(int j = 0; j < B.Length; j++) {
        // Verificando se os elementos são iguais
        if(A[i] == B[j]) {
          Console.WriteLine(A[i]);
        }
      }
    }
  }
}
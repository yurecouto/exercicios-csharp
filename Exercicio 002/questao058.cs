using System;

/*
Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir 
também o maior. A quantidade de números lidos será definida pelo usuário.
*/

public class Program {
  public static void Main() {
    // pede ao usuário o tamanho do vetor
    Console.Write("Digite a quantidade de números a serem lidos: ");
    int n = int.Parse(Console.ReadLine());

    // declara e inicializa o vetor com tamanho n
    int[] numeros = new int[n];

    // faz a leitura dos números e armazena no vetor
    for (int i = 0; i < n; i++) {
      Console.Write($"Digite o {i+1}º número: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }

    // calcula a média
    int soma = 0;
    for (int i = 0; i < n; i++) {
      soma += numeros[i];
    }
    double media = (double)soma / n;

    // encontra o maior número
    int maior = numeros[0];
    for (int i = 1; i < n; i++) {
      if (numeros[i] > maior) {
        maior = numeros[i];
      }
    }

    // exibe os resultados
    Console.WriteLine($"A média é {media:F2}");
    Console.WriteLine($"O maior número é {maior}");
  }
}

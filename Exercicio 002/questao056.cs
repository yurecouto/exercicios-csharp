using System;

/*
Fazer um programa para ler um vetor de inteiros positivos de 50 posições. Imprimir a quantidade de números 
pares e de múltiplos de 5. 
*/

public class Program {
    public static void Main() {
        int[] numeros = new int[50];
        int countPares = 0, countMultiplosDe5 = 0;

        for (int i = 0; i < 50; i++) {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0) {
                countPares++;
            }
            if (numeros[i] % 5 == 0) {
                countMultiplosDe5++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {countPares}");
        Console.WriteLine($"Quantidade de múltiplos de 5: {countMultiplosDe5}");
    }
}

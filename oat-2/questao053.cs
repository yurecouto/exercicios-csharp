using System;

/*
Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os 
tempos registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir: 
i. melhor tempo; 
ii. a volta em que o melhor tempo ocorreu; 
iii. tempo médio das N voltas; 
*/

public class Program {
    public static void Main() {
        Console.Write("Digite o número de voltas: ");
        int n = int.Parse(Console.ReadLine());

        double[] tempos = new double[n];
        double melhorTempo = double.MaxValue;
        int voltaMelhorTempo = 0;
        double somaTempos = 0;

        for (int i = 0; i < n; i++) {
            Console.Write($"Digite o tempo da volta {i + 1}: ");
            tempos[i] = double.Parse(Console.ReadLine());

            // Verifica se o tempo atual é o melhor até agora
            if (tempos[i] < melhorTempo) {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }

            somaTempos += tempos[i];
        }

        // Imprime o resultado
        Console.WriteLine($"Melhor tempo: {melhorTempo:F2}s (volta {voltaMelhorTempo})");
        Console.WriteLine($"Tempo médio: {somaTempos / n:F2}s");
    }
}
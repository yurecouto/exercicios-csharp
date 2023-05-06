using System;

/*
Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas vezes aparece o número 1, 3 e 4, nesta 
ordem. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1. 
*/

public class Program {
    public static void Main() {
        Console.Write("Quantidade de alunos: ");
        int n = int.Parse(Console.ReadLine());

        double[] notas = new double[n];
        double soma = 0.0;

        for (int i = 0; i < n; i++) {
            Console.Write($"Nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma += notas[i];
        }

        double media = soma / n;
        Console.WriteLine($"Média aritmética: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        int acimaSete = 0;
        for (int i = 0; i < n; i++) {
            if (notas[i] > 7.0) {
                acimaSete++;
            }
        }

        if (acimaSete > 0) {
            Console.WriteLine($"Alunos com nota acima de 7.0: {acimaSete}");
        } else {
            Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
        }
    }
}
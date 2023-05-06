using System;

/*
Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). 
Ler um valor maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). 
Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor. 
*/

public class Program {
    public static void Main() {

        int a, b, c;
        int maior, menor;

        Console.WriteLine("Digite três valores inteiros maiores que zero:");

        do {
            Console.Write("Valor de A: ");
            a = int.Parse(Console.ReadLine());
        } while (a <= 0);

        do {
            Console.Write("Valor de B: ");
            b = int.Parse(Console.ReadLine());
        } while (b <= 0);

        do {
            Console.Write("Valor de C: ");
            c = int.Parse(Console.ReadLine());
        } while (c <= 0);

        maior = Math.Max(a, Math.Max(b, c));
        menor = Math.Min(a, Math.Min(b, c));

        Console.WriteLine("Menor valor multiplicado pelo maior valor: " + (maior * menor));
        Console.WriteLine("Maior valor dividido pelo menor valor: " + ((double)maior / menor));
    }
}

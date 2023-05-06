using System;

/*
Questão 1: Faça um programa em C# (com a estrutura do...while) que leia 20 valores
inteiros e:
- Encontre e mostre o maior valor;
- Encontre e mostre o menor valor;
- Calcule e mostre a média dos números lidos;
*/

class Program
{
    static void Main()
    {
        int contador = 0;
        int valor;
        int soma = 0;
        int maior = int.MinValue;
        int menor = int.MaxValue;

        do
        {
            Console.Write("Digite um valor inteiro: ");
            valor = int.Parse(Console.ReadLine());
            contador++;
            soma += valor;
            if (valor > maior)
            {
                maior = valor;
            }
            if (valor < menor)
            {
                menor = valor;
            }
        } while (contador < 20);

        double media = (double)soma / 20;

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Média: " + media);
    }
}
using System;

/*
Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar 
a soma de todos dos resultados da multiplicação de x[i] por y[i]. 
*/

public class Program
{
    public static void Main()
    {
        // Definir os vetores x e y
        int[] x = { 1, 2, 3 };
        int[] y = { 4, 5, 6 };
        int n = x.Length; // número de elementos nos vetores

        // Calcular o produto escalar
        int produtoEscalar = 0;
        for (int i = 0; i < n; i++)
        {
            produtoEscalar += x[i] * y[i];
        }

        // Imprimir o resultado
        Console.WriteLine($"O produto escalar entre x e y é {produtoEscalar}.");
    }
}
using System;

/*
Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha idade entre 18 e 20 anos 
para participar de uma campanha publicitária milionária de produtos de beleza. Foram inscritas 20 candidatas e, ao se inscreverem, 
forneceram nome e idade. Tais informações foram armazenadas em 2 vetores distintos. Faça um programa para imprima o vetor que contém 
os nomes das candidatas aptas a concorrer a uma vaga para a campanha milionária. 
*/

public class Program
{
    public static void Main()
    {
        // vetor com as idades das candidatas
        int[] idades = { 18, 19, 20, 21, 22, 18, 19, 20, 23, 24, 18, 19, 20, 25, 26, 18, 19, 20, 27, 28 };

        // vetor com os nomes das candidatas
        string[] nomes = { "Ana", "Bia", "Clara", "Duda", "Eva", "Flávia", "Gabriela", "Helena", "Isabela", "Julia", "Kamila", "Larissa", "Mariana", "Natalia", "Olivia", "Paula", "Quezia", "Rita", "Sofia", "Tatiana" };

        // vetor para armazenar os nomes das candidatas aptas
        string[] candidatasAptas = new string[20];
        int contador = 0;

        // pede a idade mínima das candidatas
        Console.Write("Digite a idade mínima das candidatas: ");
        int idadeMinima = int.Parse(Console.ReadLine());

        // pede a idade máxima das candidatas
        Console.Write("Digite a idade máxima das candidatas: ");
        int idadeMaxima = int.Parse(Console.ReadLine());

        // percorre os vetores de idade e nome ao mesmo tempo
        for (int i = 0; i < idades.Length; i++)
        {
            // verifica se a idade da candidata está dentro do intervalo desejado
            if (idades[i] >= idadeMinima && idades[i] <= idadeMaxima)
            {
                // adiciona o nome da candidata ao vetor de candidatas aptas
                candidatasAptas[contador] = nomes[i];
                contador++;
            }
        }

        // imprime os nomes das candidatas aptas
        Console.WriteLine("\nCandidatas aptas para a campanha publicitária:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(candidatasAptas[i]);
        }

        Console.ReadLine();
    }
}

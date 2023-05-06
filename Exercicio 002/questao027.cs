using System;

/*
Escreva um programa que leia: 
a quantidade de números que deverá processar; 
os números que deverá processar,e calcule e exiba, para cada número a ser 
processado o seu fatorial. Lembrete: O fatorial de um número N é dado pela fórmula: N!= 1*2*3*4* 5 * ... * N 
*/

namespace Fatorial
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Digite a quantidade de números que deseja processar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i+1}º número: ");
                int numero = int.Parse(Console.ReadLine());

                int fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            }

            Console.ReadLine();
        }
    }
}
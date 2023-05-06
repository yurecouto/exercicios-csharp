using System;

/*
Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos 
ímpares a partir do número informado pelo usuário menor que 10 e maior que zero.
*/

namespace Exercicio
{
    public class Program
    {
        public static void Main()
        {
            int numero;

            do
            {
                Console.Write("Digite um número entre 1 e 9: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 9)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            } while (numero < 1 || numero > 9);

            int somaQuadrados = SomaQuadradosNumerosImpares(numero);

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números inteiros ímpares a partir do número {numero} é {somaQuadrados}.");

        }

        public static int SomaQuadradosNumerosImpares(int numero)
        {
            int soma = 0;
            int contador = 0;
            int numeroAtual = numero;

            while (contador < 20)
            {
                if (numeroAtual % 2 != 0)
                {
                    soma += (int)Math.Pow(numeroAtual, 2);
                    contador++;
                }
                numeroAtual++;
            }

            return soma;
        }
    }
}
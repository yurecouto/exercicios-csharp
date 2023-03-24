using System;

/*Faça um programa que exiba os números de 1 até 2000. */

namespace ExibirNumeros
{
    public class Program
    {
        public static void Main()
        {
            ExibirNumerosAte2000();
        }

        public static void ExibirNumerosAte2000()
        {
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
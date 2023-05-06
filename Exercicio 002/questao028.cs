using System;

/*
Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.
*/

namespace NumerosImparesEntre100e200
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
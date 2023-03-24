using System;

/*Escreva um programa que exiba os números de 1 a 100 na tela em ordem decrescente.*/

namespace NumerosDecrescentes
{
    public class Program
    {
        public static void Main()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
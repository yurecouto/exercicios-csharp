using System;

/*
 Faça um programa para imprimir uma tabuada.
*/

namespace Tabuada
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Digite um número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + numero + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.ReadKey();
        }
    }
}

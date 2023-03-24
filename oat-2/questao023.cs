using System;

/*
Escreva um programa que exiba as seguintes opções e realize os que se pede em cada uma delas: 
1 - Adição 
2 - Subtração 3- Multiplicação 
4 - Divisão 
*/

namespace Calculadora
{
    public class Program
    {
        public static void Main()
        {
            int opcao;
            double num1, num2, resultado;

            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"O resultado da adição é: {resultado}");
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"O resultado da subtração é: {resultado}");
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"O resultado da divisão é: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}

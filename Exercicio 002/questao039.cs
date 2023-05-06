using System;

/*
Faça um programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar,
e se é positivo ou negativo. O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, 
"Deseja encerrar o programa?".
*/

namespace ParOuImparPositivoOuNegativo
{
    public class Program
    {
        public static void Main()
        {
            char resposta = 'N';
            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }

                Console.Write("Deseja encerrar o programa? (S/N) ");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta != 'S' && resposta != 's');
        }
    }
}
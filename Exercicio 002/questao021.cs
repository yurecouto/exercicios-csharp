using System;

/*
Faça um programa que leia um número inteiro e mostre uma mensagem na tela indicando se este número é 
positivo ou negativo. Pare a execução do programa quando o usuário requisitar. 
*/

public class Program {
    public static void Main() {
        int numero;
        bool continuar = true;

        while (continuar) {
            Console.Write("Digite um número inteiro (0 para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0) {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0) {
                Console.WriteLine("O número é negativo.");
            }
            else {
                continuar = false;
            }
        }
    }
}
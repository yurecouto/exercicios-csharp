using System;

/*
Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O 
método deverá receber um número inteiro (n) e deverá retornar a mensagem "PAR" ou "ÍMPAR”. 
*/

public class Program {
    public static void Main() {
        // solicita ao usuário um número inteiro
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        // verifica se o número é par ou ímpar
        string resultado = Verifica(num);

        // exibe o resultado na tela
        Console.WriteLine(resultado);
    }

    public static string Verifica(int n) {
        // se o resto da divisão por 2 for 0, o número é par
        if (n % 2 == 0) {
            return "PAR";
        } else {
            return "ÍMPAR";
        }
    }
}
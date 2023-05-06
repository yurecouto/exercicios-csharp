using System;

/*
Escrever um programa que leia um conjunto de números positivos, e exiba se o número lido é par ou ímpar. 
Exiba ao final a soma total dos números pares lidos e também a soma dos números ímpares lidos. Suporemos 
que o número de elementos deste conjunto não é conhecido, e que um número negativo será utilizado 
para sinalizar o fim dos dados. 
*/

public class Program {
    public static void Main() {
        int num, pares = 0, impares = 0;
        Console.WriteLine("Digite um número positivo ou um número negativo para sair:");
        
        do {
            num = int.Parse(Console.ReadLine());
            if (num > 0) {
                if (num % 2 == 0) {
                    Console.WriteLine("O número {0} é par", num);
                    pares += num;
                }
                else {
                    Console.WriteLine("O número {0} é ímpar", num);
                    impares += num;
                }
            }
        } while (num >= 0);

        Console.WriteLine("A soma dos números pares é {0}", pares);
        Console.WriteLine("A soma dos números ímpares é {0}", impares);
    }
}

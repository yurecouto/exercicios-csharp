using System;

/*
Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma mensagem: "Múltiplo de 10".
*/

public class Program {
    public static void Main() {
        for (int i = 1; i <= 100; i++) {
            Console.Write(i + " ");
            if (i % 10 == 0) {
                Console.WriteLine("Múltiplo de 10");
            }
        }
        Console.ReadKey();
    }
}
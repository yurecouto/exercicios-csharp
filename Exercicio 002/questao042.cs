using System;

/*
Faça um programa que determine o maior e o menor entre N números lidos. A condição de parada é a entrada de 
um valor 0, ou seja, o programa deve ficar executando até que a entrada seja igual a 0 (ZERO). 
*/

public class Program {
    public static void Main() {

        int numero;
        int maior = int.MinValue; // Valor mínimo para que qualquer número seja maior que ele
        int menor = int.MaxValue; // Valor máximo para que qualquer número seja menor que ele
        
        do {
            Console.Write("Digite um número (0 para sair): ");
            numero = int.Parse(Console.ReadLine());
            
            if (numero != 0) {
                if (numero > maior) {
                    maior = numero;
                }
                if (numero < menor) {
                    menor = numero;
                }
            }
            
        } while (numero != 0);
        
        Console.WriteLine("Maior número: " + maior);
        Console.WriteLine("Menor número: " + menor);
        
        Console.ReadLine(); // Aguarda uma entrada do usuário para encerrar o programa
    }
}
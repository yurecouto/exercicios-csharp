using System;

/*
Faça um algoritmo que leia dois valores inteiros A e B se os valores forem
iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de
qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e
mostrar seu conteúdo na tela.
*/

public class Program {
  public static void Main() {
    // Lendo os valores de A e B
    Console.Write("Digite o valor de A: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
    int B = int.Parse(Console.ReadLine());

    int C;

    // Verificando se A e B são iguais
    if (A == B) {
      C = A + B;
    } else {
      C = A * B;
    }

    // Mostrando o resultado na tela
    Console.WriteLine("O resultado é: {0}", C);
  }
}
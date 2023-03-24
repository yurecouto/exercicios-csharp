using System;

/*
Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso
seja negativo, imprimindo o resultado.
*/

public class Program {
  public static void Main() {
    // Lendo o número do usuário
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    int resultado;

    // Verificando se o número é positivo ou negativo
    if (numero >= 0) {
      resultado = numero * 2;
    } else {
      resultado = numero * 3;
    }

    // Mostrando o resultado na tela
    Console.WriteLine("O resultado é: {0}", resultado);
  }
}
using System;

/*
Fazer um programa que sorteie um número de 0 a 100 e que permita que o usuário (sem conhecer o número sorteado) 
tente acertar. Caso não acerte, o programa deve imprimir uma mensagem informando se o número sorteado é
maior ou menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a quantidade de tentativas feitas.
*/

public class Program {
  public static void Main() {
    Random random = new Random();
    int numeroSorteado = random.Next(101);
    int tentativas = 0;
    int tentativaUsuario;
    bool acertou = false;

    Console.WriteLine("Tente adivinhar o número sorteado (de 0 a 100)!");
    while (!acertou) {
      Console.Write("Digite sua tentativa: ");
      tentativaUsuario = int.Parse(Console.ReadLine());
      tentativas++;

      if (tentativaUsuario == numeroSorteado) {
        acertou = true;
        Console.WriteLine("Parabéns, você acertou em {0} tentativas!", tentativas);
      }
      else {
        Console.WriteLine("Tente novamente! O número sorteado é {0}.", 
                          tentativaUsuario < numeroSorteado ? "maior" : "menor");
      }
    }
  }
}
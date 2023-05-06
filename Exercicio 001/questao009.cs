using System;

/*
Tendo como dados de entrada a altura e o sexo de uma pessoa, construa um
algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
● para homens: (72.7 * h) – 58;
● para mulheres: (62.1 * h) – 44.7.
*/

public class Program {
  public static void Main() {
    // Lendo a altura e o sexo da pessoa
    Console.Write("Digite a altura da pessoa (em metros): ");
    double altura = double.Parse(Console.ReadLine());

    Console.Write("Digite o sexo da pessoa (M para masculino e F para feminino): ");
    string sexo = Console.ReadLine();

    // Calculando o peso ideal
    double pesoIdeal;
    if (sexo == "M") {
      pesoIdeal = (72.7 * altura) - 58;
    } else if (sexo == "F") {
      pesoIdeal = (62.1 * altura) - 44.7;
    } else {
      Console.WriteLine("Sexo inválido.");
      return;
    }

    // Imprimindo o resultado
    Console.WriteLine("O peso ideal da pessoa é " + pesoIdeal + " kg.");
  }
}

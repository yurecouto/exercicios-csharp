using System;

/*
Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa.
Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada
(anos).
*/

public class Program {
  public static void Main() {
    // Lendo os dados da pessoa
    Console.Write("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o sexo da pessoa (M ou F): ");
    char sexo = char.Parse(Console.ReadLine());

    Console.Write("Digite o estado civil da pessoa (SOLTEIRO, CASADO ou DIVORCIADO): ");
    string estadoCivil = Console.ReadLine();

    // Verificando se a pessoa é mulher casada
    if (sexo == 'F' && estadoCivil == "CASADO") {
      // Solicitando o tempo de casamento em anos
      Console.Write("Digite o tempo de casamento em anos: ");
      int tempoCasamento = int.Parse(Console.ReadLine());

      Console.WriteLine("A pessoa {0} está casada há {1} anos.", nome, tempoCasamento);
    } else {
      Console.WriteLine("A pessoa {0} é do sexo {1} e estado civil {2}.", nome, sexo, estadoCivil);
    }
  }
}
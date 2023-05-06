using System;

/*
Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do 
menor número. Se os dois números forem iguais, o programa deve exibir mensagem informando este fato. 
*/

public class Mainpublic class {
  public static void Main () {
    int num1, num2;
    Console.Write("Digite o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    num2 = int.Parse(Console.ReadLine());
    
    if(num1 > num2){
      Console.WriteLine("Maior número: " + num1);
      Console.WriteLine("Menor número: " + num2);
    } else if(num2 > num1){
      Console.WriteLine("Maior número: " + num2);
      Console.WriteLine("Menor número: " + num1);
    } else {
      Console.WriteLine("Os dois números são iguais: " + num1);
    }
  }
}

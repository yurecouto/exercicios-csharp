using System;

/*
Escreva um programa que leia um número inteiro e exiba o seu módulo. 
O módulo de um número x é: 
x se x é maior ou igual a zero 
x* (-1) se x é menor que zero 
*/

public class Program {
  public static void Main() {
    Console.Write("Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine());
    
    int modulo;
    if (numero >= 0) {
        modulo = numero;
    } else {
        modulo = numero * (-1);
    }
    
    Console.WriteLine("O módulo do número digitado é: " + modulo);
  }
}
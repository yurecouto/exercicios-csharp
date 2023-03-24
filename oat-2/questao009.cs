using System;

/*
Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
meses e dias e escreva a idade dessa pessoa expressa apenas em dias. 
Considerar ano com 365 dias e mês com 30 dias. 
*/

public class Program {
    public static void Main() {
        Console.Write("Digite a idade em anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Digite a idade em dias: ");
        int dias = int.Parse(Console.ReadLine());

        int idadeEmDias = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine($"A idade em dias é: {idadeEmDias}");
    }
}
using System;

/*
Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que 
o aluno foi aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, 
solicitar a nota do recuperação, somar com o valor da média e obter a nova média. Se a nova média 
for maior ou igual a 7, apresentar uma mensagem informando que o aluno foi aprovado na recuperação. 
Se o aluno não foi aprovado, apresentar uma mensagem informando esta condição. 
Apresentar junto com as mensagens o valor da média do aluno. 
*/

public class Program {
    public static void Main() {
        // Lê as quatro notas do aluno
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        // Calcula a média
        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

        if (media >= 7.0) {
            // Se a média for maior ou igual a 7, o aluno foi aprovado
            Console.WriteLine($"O aluno foi aprovado com média {media:F2}");
        } else {
            // Se a média for menor que 7, o aluno precisa de recuperação
            Console.Write("Digite a nota da recuperação: ");
            double notaRecuperacao = double.Parse(Console.ReadLine());

            // Calcula a nova média
            double novaMedia = (media + notaRecuperacao) / 2.0;

            if (novaMedia >= 7.0) {
                // Se a nova média for maior ou igual a 7, o aluno foi aprovado na recuperação
                Console.WriteLine($"O aluno foi aprovado na recuperação com média {novaMedia:F2}");
            } else {
                // Caso contrário, o aluno não foi aprovado
                Console.WriteLine($"O aluno não foi aprovado, média final {novaMedia:F2}");
            }
        }
    }
}
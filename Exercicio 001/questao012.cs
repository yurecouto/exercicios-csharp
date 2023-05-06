using System;

/*
Escreva um algoritmo que leia o número de identificação, as 3 notas obtidas
por um aluno nas 3 verificações e a média dos exercícios que fazem parte da
avaliação, e calcule a média de aproveitamento, usando a fórmula:
MA = (nota1 + nota 2 * 2 + nota 3 * 3 + ME)/7
A atribuição dos conceitos obedece a tabela abaixo. O algoritmo deve escrever
o número do aluno, suas notas, a média dos exercícios, a média de
aproveitamento, o conceito correspondente e a mensagem 'Aprovado' se o
conceito for A, B ou C, e 'Reprovado' se o conceito for D ou E.
Média de aproveitamento Conceito
>= 90 A
>= 75 e < 90 B
>= 60 e < 75 C
>= 40 e < 60 D
< 40 E
*/

public class Program
{
    public static void Main()
    {
        int idAluno;
        double nota1, nota2, nota3, mediaExercicios, mediaAproveitamento;
        string conceito;

        Console.Write("Digite o número de identificação do aluno: ");
        idAluno = int.Parse(Console.ReadLine());

        Console.Write("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a média dos exercícios: ");
        mediaExercicios = double.Parse(Console.ReadLine());

        // Calcula a média de aproveitamento
        mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

        // Atribui o conceito de acordo com a média de aproveitamento
        if (mediaAproveitamento >= 90)
        {
            conceito = "A";
        }
        else if (mediaAproveitamento >= 75)
        {
            conceito = "B";
        }
        else if (mediaAproveitamento >= 60)
        {
            conceito = "C";
        }
        else if (mediaAproveitamento >= 40)
        {
            conceito = "D";
        }
        else
        {
            conceito = "E";
        }

        Console.WriteLine("Número de identificação: " + idAluno);
        Console.WriteLine("Nota 1: " + nota1);
        Console.WriteLine("Nota 2: " + nota2);
        Console.WriteLine("Nota 3: " + nota3);
        Console.WriteLine("Média dos exercícios: " + mediaExercicios);
        Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento.ToString("F2"));
        Console.WriteLine("Conceito: " + conceito);

        // Verifica se o aluno foi aprovado ou reprovado
        if (conceito == "A" || conceito == "B" || conceito == "C")
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}

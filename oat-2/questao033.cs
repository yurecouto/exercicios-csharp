using System;

/*
Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de 
alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão. 
*/

public class Aluno {
    public int matricula;
    public double nota;

    public Aluno(int matricula, double nota) {
        this.matricula = matricula;
        this.nota = nota;
    }
}

public class Program {
    public static void Main() {
        double somaNotas = 0;
        int contadorAlunos = 0;

        while (true) {
            Console.Write("Digite a matrícula do aluno (ou um número negativo para sair): ");
            int matricula = int.Parse(Console.ReadLine());

            if (matricula < 0) {
                break;
            }

            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(matricula, nota);
            somaNotas += nota;
            contadorAlunos++;
        }

        double mediaNotas = somaNotas / contadorAlunos;

        Console.WriteLine("Média das notas dos alunos: " + mediaNotas);
    }
}

using System;

/*
Faça um programa de conversão de base numérica. O programa deverá apresentar uma tela de entrada com as 
seguintes opções: 
1 - Adição 
2 - Subtração 
3- Multiplicação 4 - Divisão 
Informe a opção: 
A partir da opção escolhida, o programa deverá solicitar para que o usuário digite dois números. Em seguida, 
o programa deve exibir o resultado da opção indicada pelo usuário e perguntar ao usuário se ele deseja voltar 
ao menu principal. Caso a resposta seja 'S' ou 's', deverá voltar ao menu, caso contrário deverá encerrar o programa.
*/

public class Program {
    public static void Main() {
        int opcao;
        do {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao) {
                case 1:
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    double resultado = num1 + num2;
                    Console.WriteLine("O resultado da adição é: " + resultado);
                    break;
                case 2:
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case 3:
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case 4:
                    Console.Write("Digite o primeiro número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado da divisão é: " + resultado);
                    break;
                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opcao != 5);
    }
}
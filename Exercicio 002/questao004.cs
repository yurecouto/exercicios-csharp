using System;

/*
Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os valores lidos, 
baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis A, B, C e D, devem ser somados 
e multiplicados os valores de A com B, A com C e A com D; depois B com C, B com D e por último C com D. Note que para cada operação 
serão utilizadas seis combinações. Assim sendo, devem ser realizadas doze operações de processamento, sendo seis para as adições 
e seis para as multiplicações. 
*/

public class Program {
    public static void Main() {
        int a, b, c, d;

        Console.Write("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        c = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de D: ");
        d = int.Parse(Console.ReadLine());

        int ab = a + b;
        int ac = a + c;
        int ad = a + d;
        int bc = b + c;
        int bd = b + d;
        int cd = c + d;

        int ab_mult = a * b;
        int ac_mult = a * c;
        int ad_mult = a * d;
        int bc_mult = b * c;
        int bd_mult = b * d;
        int cd_mult = c * d;

        Console.WriteLine($"A soma de A e B é {ab}");
        Console.WriteLine($"A soma de A e C é {ac}");
        Console.WriteLine($"A soma de A e D é {ad}");
        Console.WriteLine($"A soma de B e C é {bc}");
        Console.WriteLine($"A soma de B e D é {bd}");
        Console.WriteLine($"A soma de C e D é {cd}");

        Console.WriteLine($"O produto de A e B é {ab_mult}");
        Console.WriteLine($"O produto de A e C é {ac_mult}");
        Console.WriteLine($"O produto de A e D é {ad_mult}");
        Console.WriteLine($"O produto de B e C é {bc_mult}");
        Console.WriteLine($"O produto de B e D é {bd_mult}");
        Console.WriteLine($"O produto de C e D é {cd_mult}");
    }
}
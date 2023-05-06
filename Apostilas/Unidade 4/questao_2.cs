using System;

/*
Faça o seguinte programa em C#. Uma loja utiliza o código V para compras à
vista e o código P para compras a prazo. Faça um algoritmo que recebe ao código (V ou P)
e o valor de 15 transações. Calcule e mostre:
- O valor total das compras à vista.
- O valor total das compras a prazo.
- O valor total das compras efetuadas.
*/

class Program
{
    static void Main()
    {
        char codigo;
        double valor;
        double totalAVista = 0;
        double totalAPrazo = 0;
        double totalGeral = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write("Digite o código (V ou P) da transação {0}: ", i);
            codigo = char.Parse(Console.ReadLine());
            Console.Write("Digite o valor da transação {0}: ", i);
            valor = double.Parse(Console.ReadLine());
            if (codigo == 'V')
            {
                totalAVista += valor;
            }
            else if (codigo == 'P')
            {
                totalAPrazo += valor;
            }
            totalGeral += valor;
        }

        Console.WriteLine("Valor total das compras à vista: " + totalAVista);
        Console.WriteLine("Valor total das compras a prazo: " + totalAPrazo);
        Console.WriteLine("Valor total das compras efetuadas: " + totalGeral);
    }
}
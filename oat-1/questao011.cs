using System;

/*
Elabore um algoritmo que calcule o que deve ser pago por um produto,
considerando o preço normal de etiqueta e a escolha da condição de pagamento.

Utilize os códigos da tabela a seguir para ler qual a condição de pagamento
escolhida e efetuar o cálculo adequado.
Código Condição de pagamento
1 À vista em dinheiro ou cheque, recebe 10% de desconto
2 À vista no cartão de crédito, recebe 15% de desconto
3 Em duas vezes, preço normal de etiqueta sem juros
4 Em duas vezes, preço normal de etiqueta mais juros de 10%
*/

public class Program {
  public static void Main() {
    double preco, valorFinal;
    int condicaoPagamento;

    Console.Write("Digite o preço normal do produto: ");
    preco = double.Parse(Console.ReadLine());

    Console.WriteLine("Escolha a condição de pagamento:");
    Console.WriteLine("1 - À vista em dinheiro ou cheque, recebe 10% de desconto");
    Console.WriteLine("2 - À vista no cartão de crédito, recebe 15% de desconto");
    Console.WriteLine("3 - Em duas vezes, preço normal de etiqueta sem juros");
    Console.WriteLine("4 - Em duas vezes, preço normal de etiqueta mais juros de 10%");
    Console.Write("Digite o código da condição de pagamento: ");
    condicaoPagamento = int.Parse(Console.ReadLine());

    switch (condicaoPagamento) {
      case 1:
        valorFinal = preco * 0.9;
        break;
      case 2:
        valorFinal = preco * 0.85;
        break;
      case 3:
        valorFinal = preco;
        break;
      case 4:
        valorFinal = preco * 1.1;
        break;
      default:
        valorFinal = 0;
        Console.WriteLine("Código de condição de pagamento inválido");
        break;
    }

    if (valorFinal > 0) {
      Console.WriteLine("Valor final a pagar: " + valorFinal.ToString("C"));
    }
  }
}

using System;

/*
Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
comissão será de 5% do total da venda e que você tem os seguintes dados: 
Identificação do vendedor 
Código da peça 
Preço unitário da peça Quantidade vendida 
*/

namespace ComissaoVendedores
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Digite a identificação do vendedor: ");
            int idVendedor = int.Parse(Console.ReadLine());

            Console.Write("Digite o código da peça: ");
            int codPeca = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça: R$ ");
            double precoPeca = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            int qtdeVendida = int.Parse(Console.ReadLine());

            double totalVenda = precoPeca * qtdeVendida;
            double comissao = totalVenda * 0.05;

            Console.WriteLine("Vendedor: " + idVendedor);
            Console.WriteLine("Código da peça: " + codPeca);
            Console.WriteLine("Preço unitário da peça: R$ " + precoPeca.ToString("F2"));
            Console.WriteLine("Quantidade vendida: " + qtdeVendida);
            Console.WriteLine("Total da venda: R$ " + totalVenda.ToString("F2"));
            Console.WriteLine("Comissão: R$ " + comissao.ToString("F2"));
        }
    }
}
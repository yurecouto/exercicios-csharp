using System;

/*
Faça um programa que leia as variáveis C e N, respectivamente código e número de horas trabalhadas de um operário. 
E calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, 
calcule o excesso de pagamento armazenando-o na variável E, caso contrário zerar tal variável. 
A hora excedente de trabalho vale R$ 20,00. No final do processamento imprimir o salário total e o salário excedente. 
O programa só deve parar de rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o programa?".
*/

namespace SalarioOperario
{
    public class Program
    {
        public static void Main()
        {
            int codigo, horasTrabalhadas;
            double salarioTotal, salarioExcedente = 0;

            char continuar = 'N';

            do
            {
                Console.Write("Informe o código do operário: ");
                codigo = int.Parse(Console.ReadLine());

                Console.Write("Informe o número de horas trabalhadas: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());

                if (horasTrabalhadas > 50)
                {
                    salarioExcedente = (horasTrabalhadas - 50) * 20.0;
                    salarioTotal = 50 * 10.0 + salarioExcedente;
                }
                else
                {
                    salarioTotal = horasTrabalhadas * 10.0;
                }

                Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");
                Console.WriteLine($"Salário excedente: R$ {salarioExcedente:F2}");

                Console.Write("Deseja encerrar o programa? (S/N): ");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar != 'S' && continuar != 's');
        }
    }
}
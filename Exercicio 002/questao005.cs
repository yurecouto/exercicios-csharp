using System;

/*
Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que 
faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. 
Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. Tendo o valor 
da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula: LITROS_USADOS = 
DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, tempo gasto, a distância percorrida e 
a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais
*/

public class Program {
  public static void Main() {
    double tempoGasto, velocidadeMedia, distancia, litrosUsados;

    Console.Write("Digite o tempo gasto na viagem (em horas): ");
    tempoGasto = double.Parse(Console.ReadLine());

    Console.Write("Digite a velocidade média durante a viagem (em km/h): ");
    velocidadeMedia = double.Parse(Console.ReadLine());

    distancia = tempoGasto * velocidadeMedia;
    litrosUsados = distancia / 12;

    Console.WriteLine("\nVelocidade média: " + velocidadeMedia.ToString("F2") + " km/h");
    Console.WriteLine("Tempo gasto: " + tempoGasto.ToString("F2") + " horas");
    Console.WriteLine("Distância percorrida: " + distancia.ToString("F2") + " km");
    Console.WriteLine("Litros de combustível utilizados: " + litrosUsados.ToString("F2"));
  }
}
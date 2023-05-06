using System;
using System.Collections.Generic;

// Faça um programa em C# que leia uma quantidade indefinida de objetos Carro,
// composto pelos atributos, marca, valor, cor, modelo e ano, e:
// - Ordene os carros pelo de maior valor;
// - Imprima na tela todos os carros ordenados do maior valor para o de menor valor;

public class Carro {
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

public class Program {
    public static void Main(string[] args) {
        List<Carro> carros = new List<Carro>();
        
        // Leitura dos carros
        Console.WriteLine("Digite as informações dos carros (Digite 'sair' para encerrar):");
        while (true) {
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            if (marca == "sair") break;
            
            Console.WriteLine("Valor: ");
            double valor = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Cor: ");
            string cor = Console.ReadLine();
            
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            
            Console.WriteLine("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            
            Carro carro = new Carro() { Marca = marca, Valor = valor, Cor = cor, Modelo = modelo, Ano = ano };
            carros.Add(carro);
        }
        
        // Ordenação dos carros pelo valor
        carros.Sort((c1, c2) => c2.Valor.CompareTo(c1.Valor));
        
        // Impressão dos carros na tela
        Console.WriteLine("Carros ordenados por valor (do maior para o menor):");
        foreach (Carro carro in carros) {
            Console.WriteLine($"Marca: {carro.Marca} | Valor: {carro.Valor} | Cor: {carro.Cor} | Modelo: {carro.Modelo} | Ano: {carro.Ano}");
        }
    }
}

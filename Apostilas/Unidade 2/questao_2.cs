using System;

/*
Pesquise como um criar um método específico dentro de uma classe em C#.
Crie dois métodos para a classe Carro criada na questão anterior. Um método chamado
Acelerar(), que retorna a string “O carro está em movimento” como resposta e outro método
Freiar() que também retorna uma string “O carro está parado” como resposta.
*/

class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public int VelocidadeMaxima;

    public Carro(string marca, string modelo, int ano, string cor, int velocidadeMaxima)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
        VelocidadeMaxima = velocidadeMaxima;
    }

    public void ImprimirDados()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Velocidade Máxima: {VelocidadeMaxima} km/h");
        Console.WriteLine();
    }

    public string Acelerar()
    {
        return "O carro está em movimento";
    }

    public string Freiar()
    {
        return "O carro está parado";
    }
}

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro("Toyota", "Corolla", 2020, "Preto", 200);
        Carro carro2 = new Carro("Honda", "Civic", 2018, "Prata", 180);
        Carro carro3 = new Carro("Chevrolet", "Onix", 2019, "Branco", 190);

        carro1.ImprimirDados();
        Console.WriteLine(carro1.Acelerar());
        Console.WriteLine(carro1.Freiar());

        Console.ReadLine();
    }
}
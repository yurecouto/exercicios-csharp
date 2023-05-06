using System;

/*
Crie uma classe de nome Carro e atribua a ela todas as propriedades que você
acredita que um carro possua. Instancie a classe Carro e preencha 3 objetos distintos.
Imprima na tela do usuário todos os atributos dos três carros.
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
}

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro("Toyota", "Corolla", 2020, "Preto", 200);
        Carro carro2 = new Carro("Honda", "Civic", 2018, "Prata", 180);
        Carro carro3 = new Carro("Chevrolet", "Onix", 2019, "Branco", 190);

        carro1.ImprimirDados();
        carro2.ImprimirDados();
        carro3.ImprimirDados();

        Console.ReadLine();
    }
}
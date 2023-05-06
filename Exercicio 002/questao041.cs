using System;

/*
Faça um programa que dada a idade de um nadador, public classifique-o em uma das seguintes categorias: 
Infantil A = 5 a 7 anos 
Infantil B = 8 a 11 anos 
- 
- 
Juvenil A = 12 a 13 anos 
Juvenil B = 14 a 17 anos 
Adultos Maiores de 18 anos
*/

public class Program {
    public static void Main() {
        int idade;

        while (true) {
            Console.Write("Digite a idade do nadador (ou S para sair): ");
            string input = Console.ReadLine();
            if (input.ToUpper() == "S") break;

            if (int.TryParse(input, out idade)) {
                string categoria;

                if (idade >= 5 && idade <= 7) {
                    categoria = "Infantil A";
                }
                else if (idade >= 8 && idade <= 11) {
                    categoria = "Infantil B";
                }
                else if (idade >= 12 && idade <= 13) {
                    categoria = "Juvenil A";
                }
                else if (idade >= 14 && idade <= 17) {
                    categoria = "Juvenil B";
                }
                else if (idade >= 18) {
                    categoria = "Adultos";
                }
                else {
                    categoria = "Idade inválida";
                }

                Console.WriteLine("Categoria: {0}\n", categoria);
            }
            else {
                Console.WriteLine("Valor inválido\n");
            }
        }
    }
}
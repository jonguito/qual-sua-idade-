using System;

class Program
{
    static void Main()
    {
        // Pergunta a idade
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        // Verifica a faixa etária
        if (idade >= 0 && idade <= 12)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade >= 13 && idade <= 17)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else if (idade >= 18 && idade <= 64)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else if (idade >= 65)
        {
            Console.WriteLine("Você é um idoso.");
        }
        else
        {
            Console.WriteLine("Idade inválida.");
        }
    }
}

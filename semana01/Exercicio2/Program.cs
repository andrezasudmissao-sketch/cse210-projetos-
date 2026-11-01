using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio2.");

        Console.Write("Qual é a sua nota conceitual? ");
        string nota = Console.ReadLine();
        int percentual = int.Parse(nota);
        
        string letra = "";

        if (percentual >= 90)
        {
          letra = "A";
        }

        else if (percentual >= 80)
        {
            letra = "B";
        }

        else if (percentual >= 70)
        {
            letra = "C";
        }

        else if (percentual >= 60)
        {
            letra = "D";
        }

        else 
        {
           letra ="F";
        }

          Console.WriteLine($"Sua nota é: {letra}");
        
        if (percentual >= 70)
        {
            Console.WriteLine("Você passou! Parabéns.");
        }
        else
        {
            Console.WriteLine("Mais sorte da próxima vez, não desista!");
    }
}
}
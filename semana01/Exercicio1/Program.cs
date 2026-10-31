using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio1.");

        Console.WriteLine("Qual é seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual é seu sobrenome?");
        string sobrenome = Console.ReadLine();
        Console.WriteLine($"Seu nome é {sobrenome}, {nome} {sobrenome}");
    }
}
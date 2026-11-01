using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio5.");

       static void ExibirBoasVindas()
   {
    Console.WriteLine("Bem-Vindo ao Programa!");
   
   }

      static void ExibirMensagemPessoal(string AndrezaGomes)
   {
    Console.WriteLine($"Olá {AndrezaGomes}");
   }

   int PerguntarNumeroFavorito()
   {
    Console.WriteLine("Qual seu numero favorito? ");
     int favorito = int.Parse(Console.ReadLine());
    return favorito;
   }


    }
}
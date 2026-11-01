using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio3.");
    //Primeira parte do exercício:

    //  Console.Write("Qual é o número mágico? ");
    //    int numeroMagico = int.Parse(Console.ReadLine()); //converter para número.

    //   Console.WriteLine("Qual é seu palpite? ");
    //   int palpite = int.Parse(Console.ReadLine());

    //    if (palpite > numeroMagico)
    //    {
    //      Console.WriteLine("Mais Baixo.");
    //    }
    //    else if (palpite < numeroMagico)
    //    {
    //      Console.WriteLine("Mais Alto.");
    //    }
    //   else
    //    {
    //      Console.WriteLine("Você acertou. Parabéns!");
    //    }
      
      
      
      string jogarNovamente;

     do
     {
    
      Random geradorAleatorio = new Random();
      int numeroMagico = geradorAleatorio.Next(1, 101);

       int palpite = -1;
       int tentativas = 0;

        // Nós poderiamos usar um laço do-while aqui...
        while (palpite != numeroMagico)
        {
            Console.Write("Qual o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            tentativas++;


            if (numeroMagico > palpite)
            {
                Console.WriteLine("Maior");
            }
            else if (numeroMagico < palpite)
            {
                Console.WriteLine("Menor");
            }
            else
            {
                Console.WriteLine("Você adivinhou o número mágico!");
            }
            
        }

        Console.WriteLine($"Você acertou em {tentativas} tentativas!");
        Console.Write("Você quer continuar jogando? ");
        jogarNovamente = Console.ReadLine();


    } while (jogarNovamente == "sim");
 }
}

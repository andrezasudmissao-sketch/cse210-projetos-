using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto Exercicio4.");

        List<int> numeros = new List<int>();

        int MinhaSoma = 0; //variável para a soma.
        

        int numero = -1;

        while (numero != 0) //A condição para continuar lendo números.
        {

               Console.Write("Digite um número (0 para sair): ");
            
            string respostaUsuario = Console.ReadLine();
            numero = int.Parse(respostaUsuario);
            
    
            if (numero != 0)
            {
                numeros.Add(numero);

                MinhaSoma += numero; //soma os numeros
            }
        }

         float media = ((float)MinhaSoma) / numeros.Count; //calcula a média
        Console.WriteLine($"A média é: {media}");

    
        int maior = numeros[0];

        foreach (int Item in numeros)
        {
            if (Item > maior)
            {
              
                maior = Item;
            }
        }
        Console.WriteLine($"A Soma é {MinhaSoma}");
        Console.WriteLine($"A média é {media}");
        Console.WriteLine($"O maior número é: {maior}");
    }
}

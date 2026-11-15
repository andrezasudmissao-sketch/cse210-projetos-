
using System;
using System.Collections.Generic;

public class MemorizarEscrituras
{
   private string referencia;
   private string escritura;
   private int versiculoInicial;
   private int versiculoFinal;
   private string EscrituraOculta;

    public MemorizarEscrituras(string _referencia, string _escritura, int _versiculoInicial, int _versiculoFinal)
    {
        referencia = _referencia;
        escritura = _escritura;
        versiculoInicial = _versiculoInicial;
        versiculoFinal = _versiculoFinal;
    }
    public void ExibirEscrituras()
    {
    Console.Clear();
    Console.WriteLine(referencia + " - " + escritura);
    Console.WriteLine("Pressione Enter para continuar ou digite sair.");
    string resposta = Console.ReadLine();

    if (resposta == "sair")
    {
        Console.WriteLine("Saindo do programa...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Continuando...");
    }
    }

    public void OcultarPalavra()
    {
        string[] palavras = EscrituraOculta.Split(' ');

        Random random = new Random();
        int indiceAleatorio = random.Next(palavras.Length);
        palavras[indiceAleatorio] = "_____";

        string escritaOculta = string.Join(" ", palavras);
        Console.WriteLine(referencia + " - " + escritaOculta);
        
        EscrituraOculta = escritaOculta;

    }
    
}
 

   
   
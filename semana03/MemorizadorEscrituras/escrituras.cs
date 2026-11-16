
using System;
using System.Collections.Generic;

public class MemorizarEscrituras
{
   private string referencia;
   private string escritura;
   private int versiculoInicial;
   private int versiculoFinal;
    private string EscrituraOculta; //→ altera o texto.

    public MemorizarEscrituras(string _referencia, string _escritura, int _versiculoInicial, int _versiculoFinal)
    {
        referencia = _referencia;
        escritura = _escritura;
        versiculoInicial = _versiculoInicial;
        versiculoFinal = _versiculoFinal;
        EscrituraOculta = _escritura;
    }
    public void ExibirEscrituras() //conversa com o usuário e mostra o resultado.
    {
    Console.Clear();
    Console.WriteLine(referencia + " - " + EscrituraOculta);
    Console.WriteLine("Pressione Enter para continuar ou digite sair.");
    string resposta = Console.ReadLine();

    if (resposta == "sair")
    {
        Console.WriteLine("Saindo do programa...");
        Environment.Exit(0);
    }
    else
    {
        OcultarPalavra();
        if (TemPalavrasOcultas())
        {
            ExibirEscrituras();
        }
        else
        {
            Console.WriteLine("Parabéns! Você memorizou toda a escritura.");
            Console.WriteLine("Pressione Enter para sair.");
            Console.ReadLine();
            Environment.Exit(0);
        }
       
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

    public bool TemPalavrasOcultas()
    {
        string[] palavras = EscrituraOculta.Split(' ');
        foreach (string palavra in palavras)
        {
            if (palavra == "_____")
                return true;
        }
        return false;
    }



    
}
 
 //if = "tomar uma decisão"
//while = "repetir"
//void = não retorna nada
//bool = retorna true ou false

   
   
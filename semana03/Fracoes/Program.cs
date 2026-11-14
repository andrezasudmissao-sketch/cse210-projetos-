
using System;

class Program
{
    static void Main(string[] args)
    {
        Fracoes f1 = new Fracoes();
        Console.WriteLine(f1.ObterFracoesEmTexto());
        Console.WriteLine(f1.ObterFracoesEmDecimal());

        Fracoes f2 = new Fracoes(5);
        Console.WriteLine(f2.ObterFracoesEmTexto());
        Console.WriteLine(f2.ObterFracoesEmDecimal());

        Fracoes f3 = new Fracoes(3, 4);
        Console.WriteLine(f3.ObterFracoesEmTexto());
        Console.WriteLine(f3.ObterFracoesEmDecimal());

        Fracoes f4 = new Fracoes(1, 3);
        Console.WriteLine(f4.ObterFracoesEmTexto());
        Console.WriteLine(f4.ObterFracoesEmDecimal());
    }
    
}
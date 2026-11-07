using System;

class Program
{
    static void Main(string[] args)
    {
       Diario diario = new Diario();
       Registro registro = new Registro(conteudo: "Hoje aprendi sobre classes e objetos em C#.");

       diario.AdicionarEntrada(registro.Conteudo);
       diario.ExibirEntradas();

       Console.WriteLine("Atividade em grupo concluída, semana 2.");
    }
}
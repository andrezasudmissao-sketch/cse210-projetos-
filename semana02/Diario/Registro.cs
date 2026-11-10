using System;
public class Registro
{
    private string _data;
    
    public void SetData(string data)
   {

    _data = data;
    
   }

    public string DiaDaSemana;


    public string _textoPergunta;


    public string _textoResposta;

     public string SetData()
    {
        
        return _data;
    }

    public void Exibir()
    {   
        Console.WriteLine("Dia da semana: " + DiaDaSemana);
        Console.WriteLine("Data: " + _data);
        Console.WriteLine("Pergunta: " + _textoPergunta);
        Console.WriteLine("Resposta: " + _textoResposta);

    }
}

using System;
public class Registro
{
    private string _conteudo;
    private DateTime _data;

    public Registro(string conteudo)
    {
        _conteudo = conteudo;
      
    }

    public string Conteudo
    {
        get { return _conteudo; }
    }

    
}


using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


public class Fracoes  //Crie uma classe para armazenar frações
{
    private int _numerador { get; set; }  //A classe deve ter dois atributos: numerador e denominador.
    private int _denominador { get; set; }
    public Fracoes()
    {
        _numerador = 1; 
        _denominador = 1;
    }
    public Fracoes(int numerador) //numerador == 6
    {
      _numerador = numerador;  //Em C# usar = para atribuir valores, não parênteses.
      _denominador = 1;
    }
    public Fracoes(int numerador, int denominador)
    {
        _numerador = numerador; //O atributo _numerador recebe o valor do parâmetro numerador.
        _denominador =denominador;
    }
    public int ObterNumerador() //DefinirNumerador → altera um valor. ObterNumerador → devolve um valor.
    {
        return _numerador;
    }

    public int DefinirNumerador(int numerador)
    {
        _numerador = numerador;
        return _numerador; //Aqui retorna o valor do numerador, mas não é necessário retornar nada, pois o método é void.
    }
    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        _denominador = denominador;
    }
    public string ObterFracoesEmTexto()  
    {
        return $"{_numerador}/{_denominador}";
    }
    public double ObterFracoesEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}

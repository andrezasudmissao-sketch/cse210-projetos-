using System;
public class Diario  //public: qualquer código pode criar um objeto dessa classe.
{
    private List<string> _entradas;  //private: só pode ser acessado dentro da própria classe Diario.
    //_entradas: nome da variável que armazenará as entradas do diário.
    public Diario()  //Diario() → construtor que inicializa a lista.
    {
        _entradas = new List<string>();  //new List(): cria uma lista vazia.
    }

    public void AdicionarEntrada(string entrada)
    {
        _entradas.Add(entrada);
    }

    public void ExibirEntradas()
    {
        foreach (var entrada in _entradas)  //"Para cada item da lista _entradas, coloque esse item na variável entrada."
        {
            Console.WriteLine(entrada);
        }
    }
}

//public: pode ser chamado de fora da classe.
//void: não retorna nenhum valor.
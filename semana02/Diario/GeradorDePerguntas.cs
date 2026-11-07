using System;
public class GeradorDePerguntas
{
    private List<string> _perguntas;

    public GeradorDePerguntas()
    {
        _perguntas = new List<string>
        {
            "Qual código você aprendeu hoje?",
            "Que auxilios você usou hoje?",
            "O conteúdo foi muito difícil de entender?",
            "O que você poderia ter feito melhor?",
        };
    }

    public string GerarPergunta()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }
}
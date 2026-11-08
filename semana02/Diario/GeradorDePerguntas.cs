using System;
public class GeradorDePerguntas
{
    private List<string> _perguntas;

    public GeradorDePerguntas()
    {
        _perguntas = new List<string>
        {
            "O que aprendi no curso hoje?",
            "Qual conceito achei mais difícil?",
            "O que consegui fazer sozinho hoje?",
            "Em qual parte do código fiquei travado?",
            "O que quero praticar amanhã?"
        };
    }



   public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indiceAleatorio = random.Next(_perguntas.Count);
        return _perguntas[indiceAleatorio];
    }
}
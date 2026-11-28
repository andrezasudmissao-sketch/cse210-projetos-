

public class AtividadeDeRespiracao : Atividade
{

    public AtividadeDeRespiracao(string nomedaatividade, string descricao, int duracao)
    : base(nomedaatividade, descricao, duracao)
        
    {
      
    }

    public void Executar()
    {
       ObterMensagemInicial();
       Console.WriteLine("Inspire profundamente...");
       ExibirContagemRegressiva(5);
       
}
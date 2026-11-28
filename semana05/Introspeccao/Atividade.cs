
using System.Globalization;

public class Atividade
{

    private string _nomedaatividade;

    private string _descricao;

    private int _duracao;


    public Atividade(string nomedaatividade, string descricao, int duracao)
    {
        _nomedaatividade = nomedaatividade;
        _descricao = descricao;
        _duracao = duracao;
    }

    public void ObterMensagemInicial()
    {
       Console.WriteLine($"Bem-vindo à atividade: {_nomedaatividade}");
       Console.WriteLine(_descricao);

        Console.Write("Qual a duração da atividade em segundos? ");
        string entrada = Console.ReadLine(); 

       _duracao = int.Parse(entrada); //Pedir a duração. Salvei a duração escolhida pelo usuário.

       Console.WriteLine("Prepare-se.....");
        
    }

    public void ExibirMensagemFinal()
    {
       string[] frames = { "-", "\\", "|", "/" }; // spinner simples

       for (int i = 0; i < 10; i++)
       {
           Console.Write(frames[i % frames.Length]);
           System.Threading.Thread.Sleep(500); // Pausa de 500ms
           Console.Write("\b"); // Move o cursor para trás para sobrescrever o símbolo

         
       }

        Console.Write($"A atividade durou {_duracao} segundo. Você concluir a {_nomedaatividade} atividade.");
       
    }
    public void ExibirProgresso(int segundos)
    {
        string[] frames = { "-", "\\", "|", "/" };

        for (int i = 0; i < segundos; i++)
        {
            Console.Write(frames[i % frames.Length]);
            System.Threading.Thread.Sleep(500); // Pausa de 500ms
            Console.Write("\b"); // Move o cursor para trás para sobrescrever o símbolo
        }

        ExibirProgresso(5);
   
    }

    
    public void ExibirContagemRegressiva(int segundos)
    {
        
        for (int i = segundos; i > 0; i--)
        
    
        {
           
            Console.Write("\r"); // Retorna o cursor para o início da linha
            Console.Write(new string(' ', Console.WindowWidth)); // Limpa a linha
            Console.Write("\r"); // Retorna o cursor para o início da linha
            Console.Write($"Tempo restante: {i} segundos");
            System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo
        }
    }
}

//i++ → aumenta
//i-- → diminui
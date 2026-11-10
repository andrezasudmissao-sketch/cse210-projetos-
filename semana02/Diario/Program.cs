using System;

class Program
{
    static void Main(string[] args)
    {
       Diario diario = new Diario();
       Registro registro = new Registro();
       registro.SetData(DateTime.Now.ToShortDateString());
       registro.Exibir();

    
    GeradorDePerguntas gerador = new GeradorDePerguntas();

       while (true)
   
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");

    string opcao = Console.ReadLine();
    
    
    switch (opcao)
{
    case "1":
       string pergunta = gerador.ObterPerguntaAleatoria();
        Console.WriteLine(pergunta); //Pergunta é exibida


        string resposta = Console.ReadLine(); //Usuário responde

        string data = DateTime.Now.ToShortDateString(); 

        Registro novoRegistro = new Registro(); //Registro é criado
        novoRegistro.SetData(data); //Registro recebe data
        novoRegistro._textoPergunta = pergunta; //Registro recebe pergunta
        novoRegistro._textoResposta = resposta; //Registro recebe resposta
        novoRegistro.DiaDaSemana = DateTime.Parse(data).DayOfWeek.ToString(); //Registro recebe dia da semana

        diario.AdicionarRegistro(novoRegistro); //"Diário, adicione este registro e guarde o registro dentro do diário"

        break;

    case "2":
        diario.ExibirTodos();


        break;

    case "3":
        diario.SalvarEmArquivo("diario.txt");

        Console.WriteLine("Digite o nome do arquivo:");
        string textoResposta = Console.ReadLine();
        diario.SalvarEmArquivo(textoResposta);


        break;

    case "4":
        diario.CarregarDeArquivo("diario.txt");

        Console.WriteLine("Digite o nome do arquivo:");
        string arquivo = Console.ReadLine();
        diario.CarregarDeArquivo(arquivo);
        break;

    case "5":
        return;

    default:
        Console.WriteLine("Opção inválida. Tente novamente.");
        break;

   
}
    
    }
    }
}

// ficou icompleto pois estava cansada e não consegui terminar, mas a ideia era criar um diário que fizesse perguntas aleatórias e o usuário pudesse responder, e depois salvar essas respostas em um arquivo.
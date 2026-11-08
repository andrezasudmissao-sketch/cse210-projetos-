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
        Console.WriteLine(pergunta);

        string resposta = Console.ReadLine();

        Registro novoRegistro = new Registro();

        break;

    case "2":
        diario.ExibirTodos();
        break;
}

   
}
    
    }
}

// ficou icompleto pois estava cansada e não consegui terminar, mas a ideia era criar um diário que fizesse perguntas aleatórias e o usuário pudesse responder, e depois salvar essas respostas em um arquivo.
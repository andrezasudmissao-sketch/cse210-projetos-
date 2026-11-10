using System;
public class Diario  //public: qualquer código pode criar um objeto dessa classe.
{
    private List<Registro> _registros;  //private: só pode ser acessado dentro da própria classe Diario.
    //_entradas: nome da variável que armazenará as entradas do diário.

    public Diario()  //construtor da classe Diario.
    {
        _registros = new List<Registro>();  //inicializa a lista de registros.
    }
    public void AdicionarRegistro(Registro registro)

   
    {
        foreach (var r in _registros)
        {
            if (r.SetData() == registro.SetData())
            {
                Console.WriteLine("Já existe um registro para esta data.");
                return;
            }
        }

      
        _registros.Add(registro);
    }
    public void ExibirTodos()
    {
        foreach (var registro in _registros)
        {
            registro.Exibir();
        }
    }

    public void SalvarEmArquivo(string Arquivo)
     
    {
        File.WriteAllLines(Arquivo, _registros.Select(r => $"{r.SetData()}|{r._textoPergunta}|{r._textoResposta}"));  //porque ele salva o estado atual completo do diário
        
    }
    
    public void CarregarDeArquivo(string Arquivo)
    
    {
        _registros.Clear(); //Remove todos os registros existentes antes de carregar novos registros do arquivo sem precisar de paramentros.

      var linhas = File.ReadAllLines(Arquivo);
      foreach (var linha in linhas)
      {
          var partes = linha.Split('|');
          if (partes.Length == 3)
          {
              var registro = new Registro();
              registro.SetData(partes[0]);
              registro._textoPergunta = partes[1];
              registro._textoResposta = partes[2];
              registro.DiaDaSemana = DateTime.Parse(partes[0]).DayOfWeek.ToString(); //Essa parte eu que adicionei. 
              _registros.Add(registro);
          }
      }

     
    }
}
      
//Não soube como corrigir esse erro no _data.
  
//public: pode ser chamado de fora da classe.
//void: não retorna nenhum valor.
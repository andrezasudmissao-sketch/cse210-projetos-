using System;
public class Diario  //public: qualquer código pode criar um objeto dessa classe.
{
    private List<Registro> _registros;  //private: só pode ser acessado dentro da própria classe Diario.
    //_entradas: nome da variável que armazenará as entradas do diário.
    public void AdiconarRegistro(Registro registro)
    {
        foreach (var r in _registros)
        {
            if (r.GetData() == registro.GetData())
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
        File.WriteAllLines(Arquivo, _registros.Select(r => $"{r.GetData()}|{r._textoPergunta}|{r._textoResposta}"));  //porque ele salva o estado atual completo do diário
        
    }

    public void CarregarDeArquivo(string Arquivo)
    {
      var linhas = File.ReadAllLines(Arquivo);
      foreach (var linha in linhas)
      {
          var partes = linha.Split('|');
          if (partes.Length == 3)
          {
              var registro = new Registro();
              registro._data = partes[0];
              registro._textoPergunta = partes[1];
              registro._textoResposta = partes[2];
              registro.DiaDaSemana = DateTime.Parse(partes[0]).DayOfWeek.ToString();
              _registros.Add(registro);
          }
      }

     
    }
}
      
//Não soube como corrigir esse erro no _data.
  
//public: pode ser chamado de fora da classe.
//void: não retorna nenhum valor.
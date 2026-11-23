

using System.Dynamic;

class PedidosOnline
{

    private class Produto
    { 

        private string Nome { get; set; }

        private int Id { get; set; }
       
        private decimal Preco { get; set; }

        private int Quantidade { get; set; }
    }
    
    private class Cliente

    {
      private string NomedoCliente; //objeto da classe Cliente

      private Endereco endereco;  //tipo = Endereco; variável = endereco (o endereço é um objeto da classe Endereco)

    }

    private class Endereco
    {
        private string Rua { get; set; }

        private string Cidade { get; set; }

        private string Estado { get; set; }

        private string Pais { get; set; }

        public bool ÉDoEUA()
    {

        if (Pais == "EUA")
       {
       return true;
       }
       else
       {
       return false;
       }
    }

    public string ObterEnderecoCompleto()
    {
        return Rua + "\n" + Cidade + "\n" + Estado + "\n" + Pais;  //"\n" quebra de linha
    }

    private class Pedido
    {
        private List<Produto> produtos = new List<Produto>();

        private Cliente cliente; //objeto da classe Cliente
    }

}
}

//return → devolve um valor.
//bool → tipo que guarda true ou false.
//if / else → uma forma comum de decidir qual valor retornar.
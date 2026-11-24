

using System.Dynamic;

class Pedidos
{

    public class Produto
    { 

        private string Nome { get; set; }

        private int Id { get; set; }
       
        private decimal Preco { get; set; }

        private int Quantidade { get; set; }

        public Produto(string nome, int id, decimal preco, int quantidade) //← construtor
        {
            Nome = nome;
            Id = id;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string ObterNome()
        {
            return Nome;
        }

        public int ObterID()
        {
            return Id;
        }

        public decimal CalcularCustoTotal()
        {
          return Preco * Quantidade;
      
        }
    }
    
    private class Cliente

    {
      private string NomedoCliente; //objeto da classe Cliente

      private Endereco enderecoCliente;  //tipo = Endereco; variável = endereco (o endereço é um objeto da classe Endereco)

      public Cliente(string nomeDoCliente, Endereco endereco)
        {
            NomedoCliente = nomeDoCliente;
            enderecoCliente = endereco;
        }

        public string ObterNomedoCliente()
    {
    return NomedoCliente;
    }

     public Endereco ObterEnderecoCliente()
    {
    return enderecoCliente;
    }

        public bool MoraNosEUA()
    {
        return enderecoCliente.ÉDoEUA();
    }

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

    }

    private class Pedido
    {
        private List<Produto> Oprodutos = new List<Produto>();

        private Cliente Ocliente; //objeto da classe Cliente

        public Pedido(Cliente cliente, List<Produto> produtos)
     {
    Ocliente = cliente;
    Oprodutos = produtos;
    
     }

        public string ObterEtiqueta()

    
    { 
       string etiqueta = "";

       foreach (Produto produto in Oprodutos)

       {

        produto.ObterNome();
        produto.ObterID();
        produto.CalcularCustoTotal();
        etiqueta += produto.ObterNome() + "\n";
       }
       return etiqueta;
    }
}
}


//return → devolve um valor.
//bool → tipo que guarda true ou false.
//if / else → uma forma comum de decidir qual valor retornar.

//NomedoCliente → atributo da classe ✅

//nomeDoCliente → parâmetro recebido ✅

//enderecoCliente → atributo da classe ✅

//endereco → parâmetro recebido ✅
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Criando um endereço
        endereco endereco = new Endereco("Rua A", "123", "Cidade X", "Estado Y", "12345-678", "Brasil");

        // Criando um cliente
        Pedidos.Cliente cliente = new Pedidos.Cliente("João Silva", endereco);

        // Criando produtos
        Pedidos.Produto produto1 = new Pedidos.Produto("Produto 1", 1, 10.0m, 2);
        Pedidos.Produto produto2 = new Pedidos.Produto("Produto 2", 2, 20.0m, 1);

        // Criando uma lista de produtos
        List<Pedidos.Produto> produtos = new List<Pedidos.Produto> { produto1, produto2 };

        // Criando um pedido
        Pedido pedido = new Pedido(cliente, produtos);

        // Calculando o custo total do pedido
        decimal custoTotal = pedido.CalcularCustoTotal();

        // Exibindo o custo total
        Console.WriteLine($"Custo Total do Pedido: {custoTotal:C}");


       
    }
}
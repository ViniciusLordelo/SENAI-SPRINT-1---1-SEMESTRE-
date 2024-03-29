using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void ListarTodos(List<Produto> produtos)
        {
            foreach(Produto item in produtos)
            {
               Console.WriteLine($"Código : {item.Codigo}");
               Console.WriteLine($"Nome : {item.Nome}");
               Console.WriteLine($"Preço : R${item.Preco}");
            }
        }
        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"Digite o código do produto");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o Nome do produto");
            produto.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o Preco do produto");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;

            
        }
    }
}
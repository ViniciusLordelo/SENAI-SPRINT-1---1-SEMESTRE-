using System;
using AulaPOO_Interface.classes;

namespace AulaPOO_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 1234;
            p1.Nome  = "PS5";
            p1.Preco = 50000;

            Produto p2 = new Produto();
            p2.Codigo = 123;
            p2.Nome  = "PS4";
            p2.Preco = 40000;

            Produto p3 = new Produto();
            p3.Codigo = 12;
            p3.Nome  = "PS3";
            p3.Preco = 30000;

            carrinho.Cadastrar(p1);
            carrinho.Listar();
            carrinho.Cadastrar(p2);

            Console.ForegroundColor = ConsoleColor.Green;

            carrinho.Alterar(p1.Codigo ,p3);
            carrinho.Listar();

            Console.ResetColor();
        }
    }
}

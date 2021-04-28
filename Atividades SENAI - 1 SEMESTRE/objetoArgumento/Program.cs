using System;
using objetoArgumento.classes;

namespace objetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {

            


            // criamos alguns produtos
            Produto produto1 = new Produto(1, "Mouse Razer 3.5", 300);
            Produto produto2 = new Produto(2, "Headset Chroma 7.1", 500);
            Produto produto3 = new Produto(3, "Mouse Pad XPTO", 120);

            //adicionamos eles ao carrinho
            Carrinho carrinho = new Carrinho();

            carrinho.AdicionarProduto(produto1);
            carrinho.AdicionarProduto(produto2);
            carrinho.AdicionarProduto(produto3);
            //carrinho.RemoverProduto(produto2); //aqui eu removo da lista
             
             //mostramos nosso carrinho completo:
            carrinho.MostrarProdutos();
        }
    }
}

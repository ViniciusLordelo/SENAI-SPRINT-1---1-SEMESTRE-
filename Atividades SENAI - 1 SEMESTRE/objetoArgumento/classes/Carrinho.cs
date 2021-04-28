using System;
using System.Collections.Generic;

namespace objetoArgumento.classes
{
    public class Carrinho
    {

        public float ValorTotal { get; set; }


        List<Produto> listaDeProdutos = new List<Produto>();



        public void AdicionarProduto(Produto produto)
        {
            listaDeProdutos.Add(produto);
        }

        public void RemoverProduto(Produto produto){
            listaDeProdutos.Remove(produto);
        }
        public void MostrarProdutos()
        {
            if (listaDeProdutos != null)
            {

                foreach (var item in listaDeProdutos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"R${item.Preco.ToString("n2")}- Nome {item.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();

            }
        }

        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            if(listaDeProdutos != null){
                foreach(Produto p in listaDeProdutos){
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total de Carrinho R$ {ValorTotal.ToString("n2")} ");
            }else{
                Console.WriteLine($"Seu carrinho está vazio!");
            }
            Console.ResetColor();
        }
    }
}
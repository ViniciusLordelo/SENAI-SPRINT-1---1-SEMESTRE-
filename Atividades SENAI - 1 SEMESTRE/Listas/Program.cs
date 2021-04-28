using System;
using System.Collections.Generic;
using Listas.classes;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produtos> produtos = new List<Produtos>();

            produtos.Add(new Produtos(1, "Apple", 3000.54f));
            produtos.Add(new Produtos(2,"Xiamo", 2500.34f));
            produtos.Add(new Produtos(3,"Samsung", 1000.54f));
           
           
           Produtos iphone = new Produtos();
           iphone.Codigo = 6;
           iphone.Nome = "Iphone XII";
           iphone.Preco = 8.000f;

           produtos.Add(iphone);

           //Produtos poderao ser mostrados com foreach
           foreach(Produtos p in produtos){
               Console.WriteLine($"{p.Nome} -  R$ {p.Preco} ");

               produtos.RemoveAt(3);

               produtos.RemoveAll(x => x.Nome == "Apple");

               Console.WriteLine("\nLista alterada ");

               foreach(Produtos g in produtos){
                   Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
               }
           }

        }
    }
}

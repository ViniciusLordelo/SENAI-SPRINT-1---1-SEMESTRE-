using System;
using metodo_construtor.classe;

namespace metodo_construtor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ultilizando o construtor vazio 

           Produto produto1 = new Produto();
           produto1.Codigo = 1;
           produto1.Nome  ="Coca-Cola";
           produto1.Descricao = "Refrigerante de cola";
           produto1.Estoque = 30;

           Console.WriteLine($"Produto 1 Código {produto1.Codigo}, nome {produto1.Nome}, Descriçaõ {produto1.Descricao}, Estoque {produto1.Estoque}");


           //Construtor inserindo apenas o codigo do

        Produto produto2 = new Produto(10);

        produto2.Nome = "Pepsi";

        Console.WriteLine($"Código inserido {produto2.Codigo}, nome {produto2.Nome}");

        //CONSTRUTOR INSERINDO TODOS OS Valores

        Produto produto3 = new Produto(1, "Traquinas","Bolacha de chocolate",1000);

        Console.WriteLine($"Codigo {produto3.Codigo}, nome {produto3.Nome}, Descrição {produto3.Descricao}, Estoque {produto3.Estoque}");
        }   
    }
}
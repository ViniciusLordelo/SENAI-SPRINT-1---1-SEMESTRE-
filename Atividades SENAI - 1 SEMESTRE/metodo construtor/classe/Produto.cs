using System;

namespace metodo_construtor.classe
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }


        //Método Construtor -

        public Produto()
        {
            Console.WriteLine("Método contrutor foi executado");
        }
        public Produto(int valor)
        {
            Codigo = valor;
            Console.WriteLine($"Código inserido foi {Codigo}");
        }

        public Produto(int codigo, string nome, string descricao, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }
    }
}

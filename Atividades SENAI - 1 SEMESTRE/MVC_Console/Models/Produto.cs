using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public Produto(int codigo, string nome, float preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;

        }
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto()
        {
            string pasta = PATH.Split("/")[0];

            // verificamos se a pasta não existe e criamos nessa condição
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);

                // verificamos se o produto csv existe, caso não exista vamos cria-lo!
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            //pegar as informaçoes do csv

            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {

                // agora separar atributos pelo ";
                string[] atributos = item.Split(";");

                //criação de produto vazio para poder colocar na lista final de produtos
                Produto prod = new Produto();
                prod.Codigo = int.Parse( atributos[0] );
                prod.Nome = atributos[1];
                prod.Preco = float.Parse( atributos[2] );

                produtos.Add( prod );





            }



            return produtos;

        }

            public void Inserir(Produto p)
        {
            // preparamos um array de string para um metodo de appendAllLines
            string[] linhas = { PrepararLinhaCSV(p) };

            //inserimos um arquivo de linhas no arquivo CSV
            File.AppendAllLines(PATH, linhas);
        }

            public string PrepararLinhaCSV(Produto prod)
        {
            //preparamos a linha para o formato do CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }


    }
}
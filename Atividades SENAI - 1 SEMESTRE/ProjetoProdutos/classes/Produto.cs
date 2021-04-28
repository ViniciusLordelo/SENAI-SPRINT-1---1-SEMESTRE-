using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes 
{
    public class Produto
    {
        public int Codigo { get; set;}

        public string NomeProduto { get; set;}

        public float Preco { get; set;}

        public DateTime DataCadastro { get; set;}

        public Marca Marca { get; set;}

        public Usuario CadastradoPor { get; set;}

        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar(){
            //Aqui são cadastrados novos produtos que foram criados acima
            //int e float contem .parse

            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o Código: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Produto: ");
            novoProduto.NomeProduto = (Console.ReadLine());

            Console.WriteLine("Digite o preço estipulado: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            novoProduto.DataCadastro = DateTime.UtcNow;

            novoProduto.Marca = Marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        }

        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item  in  ListaDeProdutos){
              Console.WriteLine($"Código {item.Codigo}");
              Console.WriteLine($"Produto {item.NomeProduto}");
              Console.WriteLine($"Preco {item.Preco}");
              Console.WriteLine($"Data de Cadastro {item.DataCadastro}");
              Console.WriteLine($"Marca {item.Marca.NomeMarca}");
              Console.WriteLine($"Cadastrado por: {item.CadastradoPor.Nome}");
              Console.WriteLine();
            }
            Console.ResetColor();

        }

        public void Deletar(int cod){
            Produto prodDeleted = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDeleted);
        }
    }

    

    

}
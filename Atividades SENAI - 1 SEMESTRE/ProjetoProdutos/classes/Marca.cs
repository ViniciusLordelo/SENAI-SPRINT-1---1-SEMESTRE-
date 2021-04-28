using System;
using System.Collections.Generic;

namespace ProjetoProdutos.classes
{
    public class Marca
    {
        public int Codigo {get; set;}

        public string NomeMarca {get; set;}

        public DateTime DataCadastro {get; set;}

        List<Marca> Marcas = new List<Marca>();
         public Marca CadastrarMarca(){

             Marca novaMarca = new Marca();

          Console.WriteLine("Digite o código da marca:");
          novaMarca.Codigo = int.Parse(Console.ReadLine());

          Console.WriteLine("Digite o nome da marca:");
          novaMarca.NomeMarca = Console.ReadLine();

          novaMarca.DataCadastro = DateTime.UtcNow;

          Marca.Add(novaMarca);

          return novaMarca; 
        }

         private static void Add(Marca novaMarca)
        {
           
        }

        public void Listar(){
           Console.WriteLine("Marcas Cadastradas: ");
           foreach(Marca item in Marcas)
           {
             Console.WriteLine($"Código: {item.Codigo}");
             Console.WriteLine($"Marca: {item.NomeMarca}");
             Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
           }
        }

        public void Deletar(int cod){

          Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
          Marcas.Remove(marcaDelete);
        }


    }
}
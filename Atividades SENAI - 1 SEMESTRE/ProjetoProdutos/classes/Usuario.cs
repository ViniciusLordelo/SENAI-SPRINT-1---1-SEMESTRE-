using System;

namespace ProjetoProdutos.classes
{
    public class Usuario
    {

        public Usuario(){
             //cadastras o usuario automaticamente quando essa classe for instanciada
            Cadastrar();
        }

        public Usuario(int _Codigo, string _Nome, string _Email, string _Senha){
            Codigo = _Codigo;
            Nome = _Nome;
            Email = _Email;
            Senha = _Senha;

        }
         public int Codigo {get; set;}

         public string Nome {get; set;}

         public string Email {get; set;}

         public string Senha {get; set;}

        public DateTime DataCadastro {get; set;}

    

        public void Cadastrar(){
            Nome = "Mash";
            Email = "mash@gmail.com";
            Senha = "123";
            DataCadastro = DateTime.UtcNow;

        }

        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("2020-12-21T21:27:30");
        }
    }
}
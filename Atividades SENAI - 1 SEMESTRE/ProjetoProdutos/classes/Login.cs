using System;

namespace ProjetoProdutos.classes
{
    public class Login
    {
        public bool Logado { get; set;}

        public Login(){

            Usuario user = new Usuario();
            Logar(user);

            if(Logado){
             GerarMenu();
            }
        }

       
        public void GerarMenu() { 

            Produto produto = new Produto();
            Marca marca = new Marca();
          string opcao = "n";

          do{
              Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar Produtos:");
            Console.WriteLine("2 - Listar Produtos: ");
            Console.WriteLine("3 - Deletar Produtos: ");
            Console.WriteLine("4 - Cadastrar Marca: ");
            Console.WriteLine("5 - Listar Marca: ");
            Console.WriteLine("6 - Deletar Marca: ");
            Console.WriteLine("0 - Sair do Aplicativo!");

            opcao = Console.ReadLine();

           switch (opcao)
           {
               case "1": 
               produto.Cadastrar();
               break;
               case "2":
               produto.Listar();

               break;
               case "3":
               Console.WriteLine("Digite um código para excluir");
               int cod = int.Parse(Console.ReadLine());
               produto.Deletar(cod);
               break;
               case "4":
               marca.CadastrarMarca();
               break;
               case "5":
               marca.Listar();
               break;
               case "6":
               Console.WriteLine("Digite um código para excluir");
               int codigoMarca = int.Parse(Console.ReadLine());
               marca.Deletar(codigoMarca);
               break;
               default:
               break;
           }

          }while(opcao != "0");


        }

        public void Logar(Usuario usuario){
            Console.WriteLine("Digite seu Email: ");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhalLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhalLogin == usuario.Senha){
                Logado = true;
                Console.WriteLine("Login efetuado com sucesso!");
            }else{
                Console.WriteLine("Falha ao logar!");
            }
                 
        }
        public void Deslogar(){
                Logado = false;
            }
    }
}
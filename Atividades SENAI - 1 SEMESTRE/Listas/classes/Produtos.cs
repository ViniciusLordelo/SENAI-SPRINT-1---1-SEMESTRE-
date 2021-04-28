namespace Listas.classes
{
    public class Produtos
    {
        public int Codigo {get; set;}

        public string Nome {get; set;}

        public float Preco {get; set;}

        public Produtos (){

        }

        public Produtos (int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}
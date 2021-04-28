namespace Ativ_08._12.classes
{
    public class Cartao
    {
        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string bandeira = "MasterCard";

        public string Bandeira
        {
            get { return bandeira; }
        }

        protected string token = "qwertyui";

        public string Token
        {
            get { return token; }
        }

        private string cvv;

        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }

        protected float limiteDeCompra = 5000;

        public float LimiteDeCompra
        {
            get { return limiteDeCompra; }
        }




        //declaração dos metodos

        public string RegistrarCompra(float saldo)
        {

            return "";
        }


        protected bool ValidarCompra(float saldo){

            return true;
        }

        protected string ValidarToken(string token){

            return "";
        }
    }
}
using System;

namespace Lógica_de_programação
{
    class Program
    {
        private const string V = " + ";

        static void Main(string[] args)
        {   //Entrada de dados
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());


             //Processamento
             int soma = valorUm + valorDois;

             //exibir

             Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);


        }
    }
}

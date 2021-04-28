﻿using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço: ");
            float preco = float.Parse(Console.ReadLine());

            TotalAPagar(quantidade, preco);

            float TotalAPagar(int quantidade, float preco){

                float total = quantidade * preco;
                float desconto; 
                if (quantidade <=5){
                    desconto = 0.02f;
                }else if( quantidade <= 10){
                    desconto = 0.03f;
                }
                else{
                    desconto = 0.05f;
                }

                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - desconto;

                Console.WriteLine($"O valor total é de:{total}");

                Console.WriteLine($"Você terá R${valorDoDesconto} de desconto");

                Console.WriteLine($"Sua compra com desconto fica R${totalComDesconto}");

                return totalComDesconto;
            }
            {

                
        }
    }
    }
}

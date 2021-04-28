using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
           
           string[] nomes = new string[5];

                Console.Write("Digite 'start' para exibir a Tabuada: ");
                var tabuada = (Console.ReadLine());

                for (int esquerda = 1; esquerda <= 10; esquerda++){
                
                    Console.WriteLine($"Tabuada do {esquerda}°");

                    for (int direita = 1; direita <= 10; direita++)
                    {
                        Console.WriteLine(esquerda + " x " + direita + " = " + esquerda * direita);
                    }
                    Console.WriteLine();

                }

            
            Console.Read();
        }
    }
}

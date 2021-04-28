using System;
using Polimorfismo.classes;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMen jogador = new MegaMen();


            Console.WriteLine($"Jogador 1 = {jogador.Correr()}");

            Zero jogador2 = new Zero();

            Console.WriteLine($"Jogador 2 = {jogador2.Correr()}");

            
        }
    }
}

using System;

namespace AULA_01._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Vinicius";
            objetoPersonagem1.idade = 18;
            objetoPersonagem1.armadura = "diamante";

            Personagem objetoPersonagem2 = new Personagem();

             objetoPersonagem1.nome = "Gau";
            objetoPersonagem1.idade = 72;
            objetoPersonagem1.armadura = "Prata";

            Console.WriteLine($"Personagem 1 = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2 = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender()}");
        }
    }
}

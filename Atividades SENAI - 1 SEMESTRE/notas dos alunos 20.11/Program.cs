using System;

namespace notas_dos_alunos_20._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            string[] nomes = new string[10];
            for (int i = 0; i <= 10; i++)
            {

            Console.WriteLine("Boletim Escolar");

            Console.WriteLine("Digite o seu nome: ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Digite a nota do 1º bimestre: ");
            int valor2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a nota do 2º bimestre: ");
            int valor3 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a nota do 3º bimestre: ");
            int valor4 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a nota do 4º bimestre: ");
            int valor5 = int.Parse(Console.ReadLine());

        
            


            float mediacalculada = Media( valor2, valor3, valor4, valor5);

            Media( valor2, valor3, valor4, valor5);

            float Media(int v2, int v3, int v4,int v5){   
            float media = (v2 + v3 + v4 + v5 )/4;
            Console.WriteLine($"A média do aluno(a) é de {media} " );
            return media;
            }

            }



            




        }
        
    }
}
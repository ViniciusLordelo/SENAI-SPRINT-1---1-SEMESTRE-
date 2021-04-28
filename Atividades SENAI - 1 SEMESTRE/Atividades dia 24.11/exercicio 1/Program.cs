using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nos diga qual o ano em que você nasceu: ");
            float Ano = float.Parse (Console.ReadLine());
            Console.WriteLine("Agora nos informe o ano atual");
            float AnoAtual = float.Parse(Console.ReadLine());

            if(Ano >= 2004){
                Console.WriteLine("Você ainda não pode votar esse ano!");
            }else if(Ano <= 2003){
                Console.WriteLine("Você já pode votar esse ano!");
            }

        }
    }
}

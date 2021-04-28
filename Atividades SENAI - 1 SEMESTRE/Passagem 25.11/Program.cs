using System;

namespace Passagem_26._11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaração de variaveis
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.WriteLine("---------------------------------");
            Console.WriteLine("----Sistema de passagem aérea----");
            Console.WriteLine("---------------------------------");


            bool senhaValida;
            do
            {

                Console.WriteLine("Digite sua senha");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);

            } while (!senhaValida);
            Console.Clear();
            //criar menu
            int escolha;
            int contador = 0;
            do
            {

                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Listar passagem");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    //Cadastrar Passagem
                    string resposta;
                    

                    do
                    {
                        if (contador < 5)
                        {
                            Console.WriteLine($"Digite o nome do {contador = 1}° Passageiro");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite a origem do {contador + 1}° Passageiro");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino do  {contador + 1}° Passageiro");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite a data do vôo do {contador + 1}° Passageiro");
                            data[contador] = Console.ReadLine();
                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("Limite excedido de passageiros");
                            break;
                        }



                        Console.WriteLine("Gostaria de cadastrar um novo passageiro?  s/n");
                        resposta = Console.ReadLine();
                    } while (resposta == "s");



                    break;
                case 2:
                    //Listar Passagem
                    for (var i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Passageiro {nomes[i]}");
                    }
                    break;
                case 0:
                    //sair
                    Console.WriteLine("Obrigado! Volte sempre!");


                    break;
                default:
                Console.WriteLine("Opção invalida!");
                    break;
            }


            } while (escolha != 0); // se a escolha for diferente de 0, ele repete








            //Funçoes
            bool EfetuarLogin(string senha)
            {

                if (senha == "123456")
                {
                    Console.WriteLine("Achei");
                    return true;

                }
                else
                {
                    Console.WriteLine("Senha Incorreta");
                    return false;
                }
            }//fim efetuar login



        }
    }
}

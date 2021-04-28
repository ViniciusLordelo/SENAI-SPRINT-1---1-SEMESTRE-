using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0, menor, i = 0, numero = 0, tl = 0;
            Console.WriteLine("Determina o maior e menor numero informado pelo usuario ");
            Console.WriteLine("Deseja informar quantos numeros?: ");
            tl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            menor = numero;
            i = 1;

            //i = i + 1
            for (i = 2; i <= tl; i++)
            {
                Console.WriteLine("Informe o " + i + " numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < menor)
                {
                    menor = numero;
                }
                if (numero > maior)
                {
                    maior = numero;
                }
            }
            Console.WriteLine("O maior numero é:  " + maior);
            Console.WriteLine("O menor numero é:  " + menor);
            Console.ReadKey();


        }

    }
}


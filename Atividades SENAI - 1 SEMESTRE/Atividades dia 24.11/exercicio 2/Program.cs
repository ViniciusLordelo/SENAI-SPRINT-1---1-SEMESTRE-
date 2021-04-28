using System;

namespace exercicio_2
{
    class Program
    {
        private static object f;

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione o tipo de combustível");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustivel");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());

            float percDesconto, desconto, valorTotal;
            float precoAlcool = 5.0f;
            float precoGasolina = 5.3f;
            switch (combustivel.ToLower())
            {

                case "a":
                    if (quantidadeCombustivel > 20)
                    {
                        percDesconto = 0.05f;
                    }
                    else
                    {
                        percDesconto = 0.03f;
                    }
                    valorTotal = (quantidadeCombustivel * precoAlcool);
                    desconto = (quantidadeCombustivel * precoAlcool)* percDesconto;
                    Console.WriteLine($"Valor a ser pago {valorTotal-desconto}");
                   break;
                case "g":
                    if (quantidadeCombustivel > 20){
                        percDesconto = 0.05f;
                    }else{
                        percDesconto = 0.03f;
                    }
                    valorTotal = (quantidadeCombustivel * precoGasolina);
                    desconto = (quantidadeCombustivel * precoGasolina)* percDesconto;
                    Console.WriteLine($"Valor a ser pago {valorTotal-desconto}");
                    break;
                default:
                    break;
            }


        }
    }
}

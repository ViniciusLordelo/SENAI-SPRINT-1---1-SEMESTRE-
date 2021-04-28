using System;
using Ativ_08._12.classes;
namespace Ativ_08._12
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;
            

            Console.WriteLine(m.Bandeira);
        }
    }
}

using System;

namespace real_em_euro 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine( Conversor.DolarParaReais(52) );
            Console.WriteLine( Conversor.RealParaDolar(52) );
        }
    }
}

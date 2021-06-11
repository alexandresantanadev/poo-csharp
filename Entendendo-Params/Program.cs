using System;
using Entendendo_Params.Models;

namespace Entendendo_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculadora.Soma( 2, 3 );
            int s2 = Calculadora.Soma(2, 4, 3);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}

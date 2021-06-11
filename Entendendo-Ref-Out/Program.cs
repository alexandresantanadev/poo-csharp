using System;
using Entendendo_Ref_Out.Models;

namespace Entendendo_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando ref
            int a = 10;
            Calculadora.TriploRef(ref a);
            System.Console.WriteLine(a);

            //Utilizando out
            int b = 10;
            int triplo;
            Calculadora.TriploOut(b, out triplo);
            System.Console.WriteLine(triplo);
        }
    }
}

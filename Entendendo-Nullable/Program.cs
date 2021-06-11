using System;

namespace Entendendo_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indica nullable;
            double? x = null;
            double? y = 10;

            //Operador de Coalecencia Nula que se o x ou y for null, vai valer 5, conforme exemplo abaixo.
            double a = x ?? 5;
            double b = y ?? 5;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

            //Mostra o valor da variável ou pega 0 caso seja null;
            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(y.GetValueOrDefault());

            //Mostra true se existe valor ou false caso seja null;
            System.Console.WriteLine(x.HasValue);
            System.Console.WriteLine(y.HasValue);

            //Abre uma excessão caso seja null;
            if (x.HasValue)
                System.Console.WriteLine(x.Value);
            else
                System.Console.WriteLine("X é null");

            if (y.HasValue)
                System.Console.WriteLine(y.Value);
            else
                System.Console.WriteLine("Y é null");
        }
    }
}

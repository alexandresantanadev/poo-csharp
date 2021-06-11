using System;

namespace Entendendo_Box_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing é o processo de conversão de um objeto tipo valor para um objeto tipo referencia compativel.
            int x = 20;
            object obj = x;

            System.Console.WriteLine(obj);
            System.Console.WriteLine(x);

            //Unboxing é o processo de conversão de um objeto tipo referência para um objeto tipo valor compativel;
            int y = (int) obj;

            System.Console.WriteLine(y);
            
        }
    }
}

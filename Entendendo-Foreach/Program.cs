using System;

namespace Entendendo_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sintaxe opcional e simplificada para percorrer coleções;

            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            
            //Leitura: para cada objeto 'obj' contido em vect, faça:    
            foreach (string obj in vect)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}

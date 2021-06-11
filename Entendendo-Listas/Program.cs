using System;
using System.Collections.Generic;

namespace Entendendo_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista é uma estrutura de dados:
            //Ordenada (elementos acessados por meio de posições);
            //Inicia vazia, e seus elementos são alocados sob demanda;
            //Cada elemento ocupa um "nó" (ou nodo) da lista;
            //Classe: List
            //Namespace: System.Collections.Generic
            //Vantagens: Tamanho variável, facilidade para se realizar inserções e deleções;
            //Desvantagens: Acesso sequencial aos elementos;

            //Declaração e instanciação de lista do tipo string;
            List<string> list = new List<string>();

            //Adiciona item a lista;
            list.Add("Alexandre");
            list.Add("Tatiane");
            list.Add("Billy");
            list.Add("Amora");

            //Adiciona item na lista em uma posição especifica;
            list.Insert(2, "Selma");

            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);

            }

            //Mostra o tamanho da lista;
            System.Console.WriteLine("List count: " + list.Count);
            System.Console.WriteLine();

            //Encontra primeiro elemento da lista que satisfaça um predicado;
            //Expressão lambda dentro de find;
            string s1 = list.Find(x => x[0] == 'A');
            System.Console.WriteLine("First 'A' : " + s1);
            System.Console.WriteLine();

            //Encontra ultimo elemento da lista que satisfaça um predicado;
            //Expressão lambda dentro de find;
            string s2 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Last 'A' : " + s2);
            System.Console.WriteLine();

            //Encontra primeira posição de elemento da lista que satisfaça um predicado;
            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("First position 'A' : " + pos1);
            System.Console.WriteLine();

            //Encontra ultima posição de elemento da lista que satisfaça um predicado;
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Last position 'A' : " + pos2);
            System.Console.WriteLine();

            //Filtrar a lista com base em um predicado;
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                System.Console.WriteLine(obj);
            }
            System.Console.WriteLine();

            //Remove um obj da lista de acordo com a definição dentro do Remove("Alexandre");
            list.Remove("Alexandre");
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine();

            //Remove todos os objetos da lista que iniciem com 'B';
            list.RemoveAll(x => x[0] == 'B');
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine();

            //Remove um objeto de acordo com a posição definida, no caso do exemplo é a posição 2;
            list.RemoveAt(2);
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            System.Console.WriteLine();

            //Remove elementos apartir de determinada posição;
            list.RemoveRange(1, 2);
            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }
        }
    }
}

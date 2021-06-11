using System;
using System.Globalization;

namespace Entendendo_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vetores são acessados por meio de posições;
            //Acessar os elementos pela sua posição
            //Homogênea (dados do mesmo tipo)

            int n = int.Parse(Console.ReadLine());

            //Váriavel abaixo do tipo vetor, instanciando a váriavel n;
            double[] vect = new double[n];

            //Laço For (para) representando: para cada váriavel i igual a 0, i menor que 0, i mais mais..
            for (int i = 0; i < n; i++)
            {
             //Váriavel vect na posição i, esperando receber os valores de cada posição, de acordo com a quantidade que será digitada;
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Váriavel soma criada já recebendo zero.
            double soma = 0.0;

            //Laço For criado para pegar os valores das posições e somar;
            for (int i = 0; i < n; i++)
            {
            //Váriavel soma;
                soma += vect[i];
            }
            //Váriavel media criada para descobrir a média das posições;
            double media = soma / n;
            //Abaixo será mostrado a média das posições;
            System.Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

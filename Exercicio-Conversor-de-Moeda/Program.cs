using System;
using System.Globalization;
using Exercicio_Conversor_de_Moeda.Models;

namespace Exercicio_Conversor_de_Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Quantos dólares você vai comprar?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Conversor(cotacao, dolar);

            System.Console.WriteLine("Valor a ser pago em reais = " + total.ToString(), "F2", CultureInfo.InvariantCulture);

        }
    }
}

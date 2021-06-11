using System;
using System.Globalization;
using Entendendo_Membros_Estáticos_Pt2.Models;

namespace Entendendo_Membros_Estáticos_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine("Valor do PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

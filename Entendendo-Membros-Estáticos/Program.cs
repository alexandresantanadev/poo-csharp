using System;
using System.Globalization;

namespace Entendendo_Membros_Estáticos
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            System.Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            System.Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine("Valor do PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}

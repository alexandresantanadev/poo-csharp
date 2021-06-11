using System;


namespace Exercicio_Conversor_de_Moeda.Models
{
    public class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Conversor(double cotacao, double dolar)
        {
            double total = dolar * cotacao;
            return total + (Iof / 100.0) * total;
        }
    }
}
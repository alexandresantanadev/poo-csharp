using System;
using System.Globalization;
namespace Exercicio_Retangulo.Models
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo()
        {
        }

        public double Area()
        {
            return Largura * Altura;

        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2.0;
        }

        public double Diagonal()
        {
            double d = (Largura * Largura) + (Altura * Altura);
            return Math.Sqrt(d);
            
        }
    }
}
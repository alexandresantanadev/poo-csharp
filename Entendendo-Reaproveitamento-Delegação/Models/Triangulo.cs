//Importação de dependências.
using System;

//Namespace da Classe.
namespace Entendendo_Reaproveitamento_Delegação
{
    //Nome da Classe.
    public class Triangulo
    {
        //Atributos da Classe.
        public double A;
        public double B;
        public double C;

        //Construtor da Classe.
        public Triangulo()
        {
        }

        //Método que calcula área da Classe Triangulo.
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt((p * (p - A) * (p - B) * (p - C)));

        }
    }
}
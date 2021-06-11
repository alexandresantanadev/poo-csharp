//Importação de dependências.
using System;
using System.Globalization;

//Namespace da classe.
namespace Entendendo_Reaproveitamento_Delegação
{
    //Nome da Classe.
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando variável do tipo triângulo.
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            //Dando a opção do usuário entrar com dados do tipo double ex: double x = 12,200.
            System.Console.WriteLine("Entre com os dados do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Dando a opção do usuário entrar com dados do tipo double ex: double x = 12,200.
            System.Console.WriteLine("Entre com os dados do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando variável do tipo double para receber o método da classe Triângulo.
            double areaX = x.Area();
            double areaY = y.Area();

            //Mostrando área do triângulo X e Y declarados acima.
            System.Console.WriteLine("Àrea do triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Àrea do triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Estrutura condicional If/Else dando instrução para mostrar qual Triângulo tem maior área.
            if (areaX > areaY)
            {
                System.Console.WriteLine("Maior Àrea: X");
            }
            else
            {
                System.Console.WriteLine("Maior Àrea: Y");
            }

        }
    }
}

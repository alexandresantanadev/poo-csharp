using System;
using System.Globalization;
using Exercicio_Funcionario.Models;

namespace Exercicio_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            System.Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            System.Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário: "+ funcionario);

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            System.Console.WriteLine("Dados atualizados: "+ funcionario);
        }
    }
}

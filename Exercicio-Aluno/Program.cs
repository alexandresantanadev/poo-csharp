using System;
using System.Globalization;
using Exercicio_Aluno.Models;

namespace Exercicio_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            System.Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            System.Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (aluno.Aprovado())
            {
                System.Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal(), "F2", CultureInfo.InvariantCulture);
                System.Console.WriteLine("APROVADO!");
            }
            else
            {
                System.Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal(), "F2", CultureInfo.InvariantCulture);
                System.Console.WriteLine("REPROVADO!");
                System.Console.WriteLine("FALTARAM " + aluno.NotaRestante());
            }
        }
    }
}

using System;
using Exercicio_Conta_Bancaria.Models;
using System.Globalization;

namespace Exercicio_Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            System.Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            System.Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                System.Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();

            System.Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            System.Console.WriteLine();

            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);

            System.Console.WriteLine();

            System.Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            System.Console.WriteLine();

            System.Console.WriteLine("Dados da conta atualizados:");
            System.Console.WriteLine(conta);
        }
    }
}

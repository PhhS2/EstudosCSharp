using System;
using System.Globalization;
using Exercicio02.Models; // Importa a model local

namespace Exercicio02.Exercicios
{
    class ExercicioConta
    {
        public static void Executar()
        {
            Conta c = new Conta();

            Console.WriteLine("\n--- CADASTRO DE CONTA ---");
            Console.Write("Número da conta: ");
            c.Numero = int.Parse(Console.ReadLine()!);

            Console.Write("Titular: ");
            c.Titular = Console.ReadLine()!;

            Console.Write("Saldo inicial: ");
            c.Saldo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("\n--- OPERAÇÕES ---");
            Console.Write("Valor para depósito: ");
            double valorDep = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Depositar(valorDep);
            Console.WriteLine("Dados da conta: " + c);

            Console.Write("\nValor para saque: ");
            double valorSaq = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Sacar(valorSaq);
            Console.WriteLine("Dados atualizados (após taxa de $5): " + c);
        }
    }
}
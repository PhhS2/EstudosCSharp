using System;
using System.Globalization;
using Exercicios1.Models;

namespace Exercicios1.Exercicios
{
    class ExercicioConta
    {
        public static void Executar()
        {
            Conta c = new Conta();

            Console.Write("Número da conta: ");
            c.Numero = int.Parse(Console.ReadLine()!);

            Console.Write("Titular: ");
            c.Titular = Console.ReadLine()!;

            Console.Write("Saldo inicial: ");
            c.Saldo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Valor para depósito: ");
            double valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Depositar(valor);

            Console.WriteLine("Dados da conta: " + c);

            Console.WriteLine();
            Console.Write("Valor para saque: ");
            valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Sacar(valor);

            Console.WriteLine("Dados atualizados: " + c);
        }
    }
}
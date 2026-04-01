using System;
using System.Globalization;
using Exercicios1.Models;

namespace Exercicios1.Exercicios
{
    class ExercicioConversorMoeda
    {
        public static void Executar()
        {
            Console.Write("qual a cotacao atual do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("quaantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
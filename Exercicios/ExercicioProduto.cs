using System;
using System.Globalization;
using Exercicios1.Models;

namespace Exercicios1.Exercicios
{
    class ExercicioProduto
    {
        public static void Executar()
        {
            Produto p = new Produto();

            Console.Write("nome do produto: ");
            p.Nome = Console.ReadLine()!;

            Console.Write("preço: ");
            p.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("dados do produto: " + p);
        }
    }
}
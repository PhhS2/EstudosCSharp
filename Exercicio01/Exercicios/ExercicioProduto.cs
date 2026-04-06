using System;
using System.Globalization;
using Exercicios1.Models;

namespace Exercicios1.Exercicios
{
    class ExercicioProduto
    {
        public static void Executar()
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine()!;

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine()!);

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine($"Dados do produto: {p}");
        }
    }
}
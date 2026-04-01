using System;
using Exercicios1.Exercicios;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha um exercício:");
            Console.WriteLine("1 - produto");
            Console.WriteLine("2 - conta");
            Console.WriteLine("3 - raio");

            string opcao = Console.ReadLine()!;

            if(opcao == "1") ExercicioProduto.Executar();
            if(opcao == "2") ExercicioConta.Executar();
            if(opcao == "3") ExercicioRaio.Executar();
            if(opcao == "4") ExercicioConversorMoeda.Executar();
            else Console.WriteLine("Opção inválida!");
        }
    }
}
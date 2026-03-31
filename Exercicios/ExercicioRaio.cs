using System;
using System.Globalization;
using Exercicios1.Models;

namespace Exercicios1.Exercicios
{
    class ExercicioRaio
    {
        public static void Executar()
        {
            Console.Write("entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circulo.Circunferencia(raio);
            Console.WriteLine("circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            
            double volume = Circulo.Volume(raio);
            Console.WriteLine("volume da esfera: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
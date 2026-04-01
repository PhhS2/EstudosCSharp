namespace Exercicios1.Models
{
    class ConversorDeMoeda
    {
        public const double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;
        }
    }
}
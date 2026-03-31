namespace Exercicios1.Models
{
    class Conta
    {
        public int Numero;
        public string Titular;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5.0; 
        }

        public override string ToString()
        {
            return $"conta {Numero}, titular: {Titular}, saldo: $ {Saldo:F2}";
        }
    }
}
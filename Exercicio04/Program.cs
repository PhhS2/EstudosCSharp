using System.Globalization;

namespace Exercicio04.Models {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine()!;

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = LerChar();

            if (resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = LerDouble();
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para depósito: ");
            double quantia = LerDouble();
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            quantia = LerDouble();
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }

        // 🔹 Método para ler char com segurança
        static char LerChar() {
            while (true) {
                string entrada = Console.ReadLine()!.Trim().ToUpper();

                if (!string.IsNullOrEmpty(entrada)) {
                    return entrada[0];
                }

                Console.Write("Entrada inválida. Digite novamente: ");
            }
        }

        static double LerDouble() {
            while (true) {
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double valor)) {
                    return valor;
                }

                Console.Write("Valor inválido. Digite novamente:");
            }
        }
    }
}
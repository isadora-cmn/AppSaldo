using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSaldo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public bool Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado de R${valor}");
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é :" + saldo);
        }

        public decimal CapturarValorDeSaque()
        {
            Console.WriteLine("Digite o valor que deseja sacar:");

            string valorDigitado = Console.ReadLine();
            decimal valorDigitadoConvertido = Convert.ToDecimal(valorDigitado);

            return valorDigitadoConvertido;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroconta, decimal saldo) {
            NumeroConta = numeroconta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }

        public void Sacar(decimal valor) {
            if (valor <= Saldo) { 
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }else {
                Console.WriteLine("Valor Desejado é maior que limite disponível");
            }
        }
        public void ExibirSaldo() {
            Console.WriteLine($"Seu saldo é de: R$ {Saldo}");
        }


    }
}
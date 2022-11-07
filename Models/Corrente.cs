using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Corrente : Conta
    {
        public Corrente(int numeroconta, decimal saldo) {
            NumeroConta = numeroconta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }

        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor) {
            if (valor <= Saldo) { 
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }else {
                Console.WriteLine("Valor Desejado é maior que limite disponível");
            }
        }
        


    }
}
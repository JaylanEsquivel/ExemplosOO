using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public sealed class Professor : Pessoa // CONCEITO CLASSE SELADA (NENHUMA CLASS PODE SER HERDADA POR ELA)
    {
        public Professor(string nome) : base(nome){

        }
    public decimal Salario { get; set; }
        public sealed override void Apresentar() //CONCEITO DE POLIMOFISMO - TAMBEM METODO SELADO NIGUEM PODE SOBRESCREVER ESSE METODO
        {
            Console.WriteLine($"Meu nome é {Nome} tenho {Idade} anos Sou um Profesor e ganho {Salario}");
        }
    }
}
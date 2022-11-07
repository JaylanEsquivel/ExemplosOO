using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome) { 

        }
        public decimal Nota { get; set; }

        public override void Apresentar() //CONCEITO DE POLIMOFISMO
        {
            Console.WriteLine($"Olá meu nome é: {Nome} tenho {Idade} e Sou um Aluno nota {Nota} ");
        }
    }
}
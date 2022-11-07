using ProjetoFinal.Models;
using ProjetoFinal.Interfaces;


// CLASSE PESSOA CONCEITO DE ABSTRACAO
Pessoa p1 = new Pessoa("Jaylan");

p1.Idade = 25;
p1.Apresentar();

// CLASSE ALUNO USANDO HERANÇA
Aluno a1 = new Aluno("Joao");

a1.Idade = 20;
a1.Nota = 10;
a1.Apresentar();

// CLASSE PROFESSOR USANDO A HERANÇA
Professor m1 = new Professor("Pedro");

m1.Idade = 34;
m1.Salario = 1400M;
m1.Apresentar();

// EXEMPLO CONTA CORRENTE ENCAPSULAMENTO
Console.WriteLine("__________________________");
Corrente c1 = new Corrente(1, 100);

c1.Creditar(10);
c1.ExibirSaldo();

// EXEMPLO DE INTERFACES
Console.WriteLine("__________________________");
ICalculadora c2 = new Calculadora();

Console.WriteLine(c2.Somar(10, 12));
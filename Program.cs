using ProjetoFinal.Models;

// CLASSE PESSOA CONCEITO DE ABSTRACAO
Pessoa p1 = new Pessoa();

p1.Nome = "Jaylan";
p1.Idade = 25;
p1.Apresentar();

// CLASSE ALUNO USANDO HERANÇA
Aluno a1 = new Aluno();

a1.Nome = "Joao";
a1.Idade = 20;
a1.Nota = 10;
a1.Apresentar();

// CLASSE PROFESSOR USANDO A HERANÇA
Professor m1 = new Professor();

m1.Nome = "Pedro";
m1.Idade = 34;
m1.Salario = 1400M;
m1.Apresentar();

// EXEMPLO CONTA CORRENTE ENCAPSULAMENTO
ContaCorrente c1 = new ContaCorrente(1, 1000);

c1.Sacar(100);
c1.ExibirSaldo();
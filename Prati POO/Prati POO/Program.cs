using Prati_POO.Interfaces;
using Prati_POO.Models;

Pessoa pessoa = new Pessoa("nomeHumano",15);
pessoa.Apresentar();
Console.WriteLine("--------------------------------------------");
ContaCorrente conta = new ContaCorrente(15687, 1500.00M);

conta.Sacar(5000.00M);
conta.Sacar(500.00M);
Console.WriteLine("--------------------------------------------");
Aluno aluno = new Aluno("Junin",15,15.13);
aluno.Apresentar();
Console.WriteLine("--------------------------------------------");
Professor professor = new Professor("adolfo", 38, 3800);
professor.Apresentar();

Console.WriteLine("--------------------------------------------");
Corrente corrente = new Corrente();
corrente.Creditar(500);
corrente.ExibirSaldo();
Console.WriteLine("--------------------------------------------");
Computador computador = new Computador();
Console.WriteLine(computador.ToString());

Console.WriteLine("--------------------------------------------");
ICalculadora cal = new Calculadora();
Console.WriteLine(cal.Dividir(4, 2));

using Prati_POO.Models;

Pessoa pessoa = new Pessoa("nomeHumano",15);
pessoa.Apresentar();

ContaCorrente conta = new ContaCorrente(15687, 1500.00M);

conta.Sacar(5000.00M);
conta.Sacar(500.00M);

Aluno aluno = new Aluno("Junin",15,15.13);
aluno.Apresentar();

Professor professor = new Professor("adolfo", 38, 3800);
professor.Apresentar();
using Propriedades_metodos_e_consturtores.Models;

Pessoa pessoa = new Pessoa(nome:"robertinho",sobrenome: "xablau",idade:1);
pessoa.Apresentar();

Pessoa pessoa1 = new Pessoa(nome: "suzan",sobrenome: "rocha",idade:5);
pessoa1.Apresentar();

Curso cursoQualquer = new Curso();
cursoQualquer.Nome = "Ingles";
cursoQualquer.Alunos = new List<Pessoa>();
cursoQualquer.AdicionarAluno(pessoa);
cursoQualquer.AdicionarAluno(pessoa1);
cursoQualquer.ListarAlunos();
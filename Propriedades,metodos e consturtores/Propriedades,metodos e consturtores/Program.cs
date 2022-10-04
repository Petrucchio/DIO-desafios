using Propriedades_metodos_e_consturtores.Models;
using System.Globalization;

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

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 1284.40M;
Console.WriteLine($"{valorMonetario:C}");
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));
long numero = 12345678910;
Console.WriteLine(numero.ToString("###-###-###-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString(" dd/MM/yyyy HH:mm"));

string datastring = "2022-04-17 18:00";
bool sucesso = DateTime.TryParseExact(datastring,
    "yyyy-MM-dd HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime date);
if (sucesso)
    Console.WriteLine($"Conversão com sucesso! Data: {date}");
else
    Console.WriteLine($"a conversão teve um problema, {datastring} não é valido");
using Propriedades_metodos_e_consturtores.Models;
using System.Globalization;

Pessoa pessoa = new Pessoa(nome:"robertinho",sobrenome: "xablau",idade:1);
pessoa.Apresentar();

//estudo codigo limpo
Console.WriteLine("------------------------------");
Pessoa pessoa1 = new Pessoa(nome: "suzan",sobrenome: "rocha",idade:5);
pessoa1.Apresentar();

//estudo listas
Console.WriteLine("------------------------------");
Curso cursoQualquer = new Curso();
cursoQualquer.Nome = "Ingles";
cursoQualquer.Alunos = new List<Pessoa>();
cursoQualquer.AdicionarAluno(pessoa);
cursoQualquer.AdicionarAluno(pessoa1);
cursoQualquer.ListarAlunos();

//estudo de localização
Console.WriteLine("------------------------------");
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 1284.40M;
Console.WriteLine($"{valorMonetario:C}");
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));
long numero = 12345678910;
Console.WriteLine(numero.ToString("###-###-###-##"));

//estudo de data
Console.WriteLine("------------------------------");
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString(" dd/MM/yyyy HH:mm"));

//estudo de tratamento
Console.WriteLine("------------------------------");
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
//estudo try catch
Console.WriteLine("------------------------------");
try
{

    //estudo ler arquivos
string[] linhas = File.ReadAllLines("C:\\Users\\vitux\\source\\repos\\DIO\\DIO-desafios\\Propriedades,metodos e consturtores\\Propriedades,metodos e consturtores\\Arquivos\\ArquivoLeitura.txt");

foreach (string line in linhas)
    Console.WriteLine(line);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex}");
}catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"O diretorio não foi encontrado {ex}");
}

catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção {ex.Message}");
}
finally
{
    Console.WriteLine("chegou até aqui");
}

//estudo throw
new ExemploExcecao().Metodo1();
Console.WriteLine("------------------------------");
//estudo fila

Queue<int> fila = new Queue<int>();
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach(int item in fila)
    Console.WriteLine(item);

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(5);

foreach (int item in fila)
    Console.WriteLine(item);

//estudo pilha
Console.WriteLine("------------------------------");
Stack<int> pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);
pilha.Push(6);

foreach (int item in pilha)
    Console.WriteLine(item);
Console.WriteLine($"Removendo o elemento : {pilha.Pop()}");
pilha.Push(7);
foreach (int item in pilha)
    Console.WriteLine(item);

//Estudo dictionary
Console.WriteLine("------------------------------");
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP","São paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
Console.WriteLine("------------------------------");
estados.Remove("BA");
estados["SP"] = "São paulo - valor alterado";
foreach (var item in estados)
    Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
string chave = "BA";
Console.WriteLine($"Verifica o elemento; {chave}");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe, é seguro adicionar  a chave: {chave}");
}

Console.WriteLine(estados["MG"]);
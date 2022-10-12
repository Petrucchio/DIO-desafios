using Propriedades_metodos_e_consturtores.Models;
using System.Globalization;
using Newtonsoft.Json;

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

//Estudo Tuplas
Console.WriteLine("------------------------------");
(int, string, string, decimal) tupla = (1, "Leonardo", "brotinho",1.85M);
Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

ValueTuple<int, string, string, decimal> outratupla = (2, "joao", "feijão", 1.90M);
var tuplacreate = Tuple.Create(3, "roger", "farinha", 1.70M);

Console.WriteLine("------------------------------");
LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, linhasArquivo, _) = arquivo.LerArquivo("C:\\Users\\vitux\\source\\repos\\DIO\\DIO-desafios\\Propriedades,metodos e consturtores\\Propriedades,metodos e consturtores\\Arquivos\\ArquivoLeitura.txt");

if (Sucesso)
{
    foreach (string linha in linhasArquivo)
        Console.WriteLine(linha);
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}

Console.WriteLine("------------------------------");
Pessoa pessoa3 = new Pessoa("leandro", "raquel", 13);

(string nome, string sobrenome) = pessoa3;

Console.WriteLine($"{nome} {sobrenome}");

//estudo if ternario
Console.WriteLine("------------------------------");

int numeroPar = 20;
bool Par = false;

Par = numeroPar % 2 == 0;
Console.WriteLine($"O número {numeroPar} é " + (Par ? "par" : "impar"));

//estudo de json
Console.WriteLine("------------------------------");
List<Venda> listavendas = new List<Venda>();
DateTime dataatual = DateTime.Now;

Venda v1 = new Venda(1, "Material de escritorio", 25.00M,dataatual);
Venda v2 = new Venda(2, "Licença de Software", 125.00M,dataatual);

listavendas.Add(v1);
listavendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listavendas);
File.WriteAllText("C:\\Users\\vitux\\source\\repos\\DIO\\DIO-desafios\\Propriedades,metodos e consturtores\\Propriedades,metodos e consturtores\\Arquivos\\vendas.json", serializado);
Console.WriteLine(serializado);
//estudo de json ler Json

string conteuArquivo = File.ReadAllText("C:\\Users\\vitux\\source\\repos\\DIO\\DIO-desafios\\Propriedades,metodos e consturtores\\Propriedades,metodos e consturtores\\Arquivos\\vendas.json");

List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(conteuArquivo);

foreach (Venda venda in vendas)
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")} ");
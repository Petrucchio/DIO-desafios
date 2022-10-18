using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade, double nota) : base(nome, idade)
        {
            Nota = nota;
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou o Aluno {Nome} e tenho {Idade} anos, com Nota {Nota}");
        }
    }
}

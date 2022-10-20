using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prati_POO.Models
{
    internal sealed class Professor : Pessoa
    {
        public Professor(string nome, int idade, double salario) : base(nome, idade)
        {
            Salario = salario;
        }

        public double Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou o Professor {Nome} e tenho {Idade} anos, com salario {Salario}");
        }
        
    }
}

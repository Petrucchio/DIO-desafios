using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_consturtores.Models
{
    internal class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome,int idade) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _Nome;
        private string _Sobrenome;
        private int _Idade;
        
        public string Nome { 
            get => _Nome; 
            set => value = (value == "") ? throw new ArgumentException("O Nome não pode ser vazio"): _Nome = value; 
        }
        public string Sobrenome {
            get => _Sobrenome;
            set => value = (value == "") ? throw new ArgumentException("O Sobrenome não pode ser vazio") : _Sobrenome = value;
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade {
            get => _Idade;
            set => value = (value < 1) ? throw new ArgumentException("A idade não pode ser menor que zero") : _Idade = value; 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}

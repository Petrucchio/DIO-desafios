using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_consturtores.Models
{
    internal class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
            try
            {
                Alunos.Remove(aluno);
                return true;
            }catch(Exception)
            {
                return false;
            }
        }

        public void ListarAlunos()
        {
            int numeracao_aluno = 1;
            Console.WriteLine($"Alunos do curso de : {Nome}");
            foreach (Pessoa aluno in Alunos) { 
                Console.WriteLine($"{numeracao_aluno}-{aluno.NomeCompleto}");
                numeracao_aluno++;
            }
        }
    }
}

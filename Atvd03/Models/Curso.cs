using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atvd03.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos{ get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarALunos()
        {
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
        
        public bool RemoverAluno(Pessoa aluno)
        {
            Console.WriteLine("Aluno removido com sucesso!");
            return Alunos.Remove(aluno);   
        }
    }
}
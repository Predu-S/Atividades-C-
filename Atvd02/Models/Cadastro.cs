using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Atvd02.Models
{
    public class Cadastro
    {
        public void Cadastrar(string nome, string cpf)
        {
            nome = Console.ReadLine();
            cpf = Console.ReadLine();
            Console.WriteLine($"O cliente {nome} foi cadastrado com sucesso");
        }

        internal string Cadastrar(string v1, object nome, string v2, object cpf)
        {
            throw new NotImplementedException();
        }
    }

 public class Busca {
    public void Buscar(string nome)
    {
         Console.WriteLine($"O cliente {nome} foi encontrado");
    } 
    

        public void Deletar(string nome)
        {
            Console.WriteLine($"O cliente {nome} foi excluido com sucesso");
        }

}
}
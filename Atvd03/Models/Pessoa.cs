using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atvd03.Models
{
    public class Pessoa
    {

        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


        private string _nome;
        private int _idade;

        public string Nome 
        { 
            get =>_nome.ToUpper();

            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("O nome não pode ser nulo");
                }
                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            get
            {
                return _idade;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
            }

        public int CPF{get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        } 
    }
}
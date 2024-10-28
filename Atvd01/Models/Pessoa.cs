using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models 
{
   public class Pessoa {
    public required string Nome { get; set; }
    public  int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá! Meu nome é {Nome} \ne eu tenho {Idade} anos.");
    }

    }
}
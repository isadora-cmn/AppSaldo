using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSaldo.Models
{
    //Quando tem sealed = significa q essa classe e a instancia final de uma herança = não pode ter classes filhas 
    public  class Professor : Pessoa
    {

        public Professor(string nome) : base(nome)
        {

        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá,meu nome é {Nome},tenho {Idade} anos,sou um Professor e ganho {Salario}");
        }
    }
}
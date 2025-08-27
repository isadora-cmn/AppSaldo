using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSaldo.Models
{
    public class Aluno : Pessoa //HERDANDO A CLASSE PESSOA
    {
        //BASE = Chamndo o construtor da classe pessoa
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar() //Usando override - sobrescrevendo para chamar a classe Aluno
        {
            Console.WriteLine($"Olá,meu nome é {Nome},tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}
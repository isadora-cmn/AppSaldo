using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSaldo.Models
{
    public abstract class Conta
    {
    //Protegido contra alterações externas mas as Cases filhas pode acessar classe filha =Corrente
        protected decimal saldo; 
        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()

        {
            Console.WriteLine("O seu saldo é :" + saldo);
        }
    }
}
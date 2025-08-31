using AppSaldo.Models;
using AppSaldo.Interfaces;

// ICalculadora calc = new Calculadora();
// Console.WriteLine(calc.Multiplicar(3, 9));


// Computador c = new Computador();

// Console.WriteLine(c.ToString());


// Pessoa p1 = new Pessoa("Leonardo");
// Aluno a1 = new Aluno("Eduardo");

// a1.Apresentar();

// Professor prof = new Professor("Otavio");


// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();



// //Classe Aluno e Prof
// Aluno a1 = new Aluno();

// a1.Nome = "Bruno";
// a1.Idade = 22;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Rafaela";
// p1.Idade = 30;
// p1.Salario = 1000;
// p1.Apresentar();



// //Conta Corrente

int numeroConta = 123;
decimal saldoInicial = 1000;

ContaCorrente contaCorrente = new ContaCorrente(numeroConta, saldoInicial);

contaCorrente.ExibirSaldo();

decimal valorSaque = contaCorrente.CapturarValorDeSaque();
bool valorSaqueRealizado = contaCorrente.Sacar(valorSaque);

if (valorSaqueRealizado == false)
{
    throw new Exception("Valor desejado é maior que o saldo disponivel");
}

contaCorrente.ExibirSaldo();
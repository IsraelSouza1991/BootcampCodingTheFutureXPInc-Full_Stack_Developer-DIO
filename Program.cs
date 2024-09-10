// Sintaxe e tipos de dados em  C#
using BootcampCodingTheFutureXPInc_Full_Stack_Developer_DIO.Models;

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Israel";
pessoa1.Idade = 32;
pessoa1.Apresentar();

Pessoa pessoa_FisicaRepresentacao =  new Pessoa();

/* Casting */

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

/* Casting implícito */

// int a = 5;
// double b = a;

// Console.WriteLine(b);

/* Não é necessário fazer uma conversão,
pois o tipo de variável que estamos tentando converter
é de um tipo que suporta */

/*Convertendo de maneira segura*/

// string a = "15";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");

/* Operador condicional */

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;

// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda Realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos a quantidade deseja em estoque.");
// }

Calculadora calc = new Calculadora();

calc.Somar(4,8);

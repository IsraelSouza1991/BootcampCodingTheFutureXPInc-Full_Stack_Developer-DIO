// Sintaxe e tipos de dados em  C#
using System.Reflection.Metadata;
using BootcampCodingTheFutureXPInc_Full_Stack_Developer_DIO.Models;

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Israel";
// pessoa1.Idade = 32;
// pessoa1.Apresentar();

// Pessoa pessoa_FisicaRepresentacao =  new Pessoa();

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

// Calculadora calc = new Calculadora();

// calc.Somar(4,8);
// calc.Subtrair(6, 19);
// calc.Multiplicar(9, 50);
// calc.Dividir(60,5);
// calc.Potencia(5,2);
// calc.PularLinha();
// int n = 30;
// calc.Seno(n);
// calc.Coseno(n);
// calc.Tangente(n);
// calc.RaizQuadrada(9);

// int num = 10;
// Console.WriteLine(num);
// Console.WriteLine("Incrementando o 10");
// // num = num +1;
// num++;
// Console.WriteLine(num);


int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

} while(numero != 0);

Console.WriteLine($"Total da soma dos números digitados é: {soma}");

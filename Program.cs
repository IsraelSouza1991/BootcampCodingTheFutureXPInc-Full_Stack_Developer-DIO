// Sintaxe e tipos de dados em  C#
using BootcampCodingTheFutureXPInc_Full_Stack_Developer_DIO.Models;

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Israel";
pessoa1.Idade = 32;
pessoa1.Apresentar();

Pessoa pessoa_FisicaRepresentacao =  new Pessoa();


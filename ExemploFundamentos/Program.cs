﻿// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

// Pessoa p = new Pessoa();
// p.Nome = "Vitor";
// p.Idade = 21;
// p.Apresentar();


// DATETIME
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); 


// CONVERTENDO VARIÁVEIS
// int a = Convert.ToInt32("5");  // Convert é usado para converter outros tipos de objeto
int a = int.Parse("5"); // Parse é um método usado somente para converter STRING em INTEIRO disparando exceptions, tem mais performance
Console.WriteLine(a);
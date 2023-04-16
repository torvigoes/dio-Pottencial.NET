// See https://aka.ms/new-console-template for more information
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
// int a = int.Parse("5"); // Parse é um método usado somente para converter STRING em INTEIRO disparando exceptions, tem mais performance
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// int a = 5;
// double b = a;
// Console.WriteLine(b);



// ESTRUTURAS CONDICIONAIS // && -> and / || -> or / ! -> not
// int quantidade = 15;
// int compra = 4;
// bool possivelComprar = compra > 0 && quantidade >= compra;
// if(compra == 0){
//     Console.WriteLine("Venda inválida");
// }
// else if(possivelComprar){
//     Console.WriteLine("Venda realizada!");
// }
// else{
//     Console.WriteLine("Quantidade indisponível!");
// }



// SWITCH CASE
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine().ToUpper();
// switch (letra){
//     case "A":
//     case "E":
//     case "I":
//     case "O":
//     case "U":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//     Console.WriteLine("Consoante");
//     break;
// }



// Operadores Lógicos
// bool maior = true;
// bool autorizacao = false;
// if(maior || autorizacao){
//     Console.WriteLine("Entrada liberada!");
// }
// else{
//     Console.WriteLine("Entrada proibida!");
// }

Calculadora calc = new Calculadora();

calc.Somar(3,5);
calc.Subtrair(4,2);
calc.Multiplicar(5,9);
calc.Dividir(17,5);
calc.Potenciacao(5,2);
using Calculadora;
using Calculadora.Basicas;

//Soma soma = new Soma();

//Console.WriteLine(soma.Calcular(18, 90));

//Subtracao subtracao = new Subtracao();
//Console.WriteLine(subtracao.Calcular(90, 27));

//Multiplicacao multiplicacao = new Multiplicacao();
//Console.WriteLine(multiplicacao.Calcular(3,2));

//Divisao divisao = new Divisao();
//Console.WriteLine(divisao.Calcular(6,2));

var calculadora = new Operacoes();

//Console.WriteLine(calculadora.Soma.Calcular(18, 22));
//Console.WriteLine(calculadora.Subtracao.Calcular(17, 4));
//Console.WriteLine(calculadora.Multiplicacao.Calcular(3, 2));
Console.WriteLine(calculadora.Divisao.Calcular(9, 0));

Console.ReadLine();
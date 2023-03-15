using OperacoesMatematicas;

OperacaoMatematica operacao = new OperacaoMatematica();

Console.WriteLine("Seja bem vindo a calculadora moderna!");
Console.WriteLine("Soma: " + operacao.Soma.Calcular(4, 6));
Console.WriteLine("Subtração: " + operacao.Subtracao.Calcular(4, 6));
Console.WriteLine("Multiplicação: " + operacao.Multiplicacao.Calcular(4, 6));
Console.WriteLine("Divisão: " + operacao.Divisao.Calcular(4,6));

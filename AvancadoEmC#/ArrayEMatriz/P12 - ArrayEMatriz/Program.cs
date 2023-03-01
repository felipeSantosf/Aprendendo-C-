using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 12: Criar um vetor A com 10 elementos inteiros. " +
            "Implementar um programa \r\nque defina e escreva a soma de todos os elementos armazenados \r\nneste vetor");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int soma = 0;
        for (int i = 0; i < a.Length; i++)
        {
            soma += a[i];
        }

        Console.WriteLine("Valor da soma dos elementos:" + soma);
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}
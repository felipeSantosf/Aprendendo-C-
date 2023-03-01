
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 14: Criar um vetor A com 10 elementos inteiros. " +
            "Implementar um programa \r\nque defina e escreva a média aritmética simples dos elementos \r\nímpares armazenados neste vetor");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int somaImpares = 0;
        int qtde = 0;
        int total;
        for(int i = 0; i< a.Length; i++)
        {
            if (a[i] % 2 != 0)
            {
                qtde++;
                somaImpares += a[i];
            }
        }

        total = somaImpares / qtde;
        Console.WriteLine("Média aritimética dos números ímpares: " + total);
        Console.WriteLine("Programa finalizado, pressione enter para continuar...");
        Console.ReadLine();




    }
}
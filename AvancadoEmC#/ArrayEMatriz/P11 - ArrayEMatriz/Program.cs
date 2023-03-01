using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício 11: Criar um vetor A com 10 elementos inteiros. " +
            "Implementar um programa \r\nque defina e escreva a quantidade de elementos armazenados neste \r\nvetor que são pares.");

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.WriteLine("Elemento " + i + " é par, valor " + a[i]);
            }
        }
        Console.WriteLine("Aplicação finalizada, pressione Enter para continuar...");
        Console.ReadLine();
    }
}
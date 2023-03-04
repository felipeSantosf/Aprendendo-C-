using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Escreva um programa que \r\nimprima cada elemento do vetor A e a relação de todos os divisores do \r\nrespectivo elemento");

        int[] a = new int[10];
        Random random = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 95);
        }

        for (int j = 0; j < a.Length; j++)
        {
            Console.WriteLine("------------------------------------------");
            for (int k = 1; k <= a[j]; k++)
            {
                if (a[j] % k == 0)
                {
                    Console.WriteLine(k + " é divisor de: " + a[j]);
                }
            }
        }
        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}
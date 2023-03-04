using System;
using System.Data;

class Program
{
    static void Main(string[] agrs)
    {
        Console.WriteLine("Criar um vetor A com 10 elementos inteiros. " +
            "Escreva um programa que \r\nimprima cada elemento do vetor A e a relação de todos os pares de 0 \r\naté o respectivo elemento.");

        int[] a = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 67);
        }


        for (int j = 0; j < a.Length; j++)
        {
            
            Console.WriteLine("---------------------");
            Console.WriteLine("A[j]: " + a[j]);
            for (int k = a[j]; k >= 0; k--)
            {
                if(k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();

    }
}
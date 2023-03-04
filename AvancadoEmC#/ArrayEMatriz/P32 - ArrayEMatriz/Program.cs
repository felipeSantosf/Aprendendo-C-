using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar um vetor A com 5 elementos inteiros. " +
            "Escreva um programa que \r\nimprima a tabuada de cada um dos elementos do vetor A");

        Random random = new Random();
        int[] a = new int[5];
        int tabuada = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(1, 19);
        }

        Console.WriteLine("Tabuada");

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine(a[i] + " * " + j + " = " + a[i] * j);

            }
        }

        Console.WriteLine("Aplicação finalizada, pressione enter para continuar...");
        Console.Read();
    }
}